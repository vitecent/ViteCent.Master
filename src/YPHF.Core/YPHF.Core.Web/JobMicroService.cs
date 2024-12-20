/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Builder;
using Quartz;
using YPHF.Core.Api.Swagger;
using YPHF.Core.Cache.Redis;
using YPHF.Core.Job.Quartz;
using YPHF.Core.Orm.SqlSugar;
using YPHF.Core.Register.Consul;
using YPHF.Core.Trace.Zipkin;

#endregion

namespace YPHF.Core.Web;

/// <summary>
///     JobMicroService 类，继承自 MicroService，用于配置和启动微服务。
/// </summary>
public class JobMicroService(string title, List<string> xmls) : MicroService
{
    /// <summary>
    ///     Quartz 调度器实例。
    /// </summary>
    private IScheduler scheduler = default!;

    /// <summary>
    ///     在构建 WebApplicationBuilder 时执行的操作。
    /// </summary>
    public Action<WebApplicationBuilder> OnBuild { get; set; } = default!;

    /// <summary>
    ///     在注册 Quartz 调度器时执行的操作。
    /// </summary>
    public Action<IScheduler> OnRegist { get; set; } = default!;

    /// <summary>
    ///     异步构建 WebApplicationBuilder。
    /// </summary>
    /// <param name="builder">WebApplicationBuilder 实例。</param>
    /// <returns>异步任务。</returns>
    protected override async Task BuildAsync(WebApplicationBuilder builder)
    {
        var configuration = builder.Configuration;
        var services = builder.Services;

        // 添加 Redis 服务
        services.AddRedis(configuration);
        // 添加 Consul 服务
        services.AddConsul(configuration);
        // 添加 Zipkin 服务
        services.AddZipkin(configuration);
        // 添加 SqlSugar ORM 服务
        services.AddSqlSugger(configuration);
        // 添加 Swagger 服务
        services.AddSwagger(title, xmls);

        // 初始化 Quartz 调度器
        scheduler = await services.AddQuarzAsync();

        // 创建并启动一个新线程来注册 Quartz 调度器
        var job = new Thread(() => OnRegist?.Invoke(scheduler))
        {
            IsBackground = true,
            Priority = ThreadPriority.Highest,
            Name = "Job"
        };

        job.Start();

        // 执行 OnBuild 操作
        OnBuild?.Invoke(builder);

        // 调用基类的 BuildAsync 方法
        await base.BuildAsync(builder);
    }

    /// <summary>
    ///     异步启动 WebApplication。
    /// </summary>
    /// <param name="app">WebApplication 实例。</param>
    /// <returns>异步任务。</returns>
    protected override async Task StartAsync(WebApplication app)
    {
        if (scheduler != null)
            // 使用 Quartz 调度器
            app.UseQuarz(scheduler);

        // 使用 Consul 服务
        await app.UseConsulAsync();
        // 使用 Zipkin 服务
        app.UseZipkin();
        // 使用 Swagger 仪表板
        app.UseSwaggerDashboard();

        // 调用基类的 StartAsync 方法
        await base.StartAsync(app);
    }
}