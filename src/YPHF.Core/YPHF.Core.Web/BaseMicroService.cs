/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using log4net;
using Microsoft.AspNetCore.Builder;
using YPHF.Core.Api.Swagger;
using YPHF.Core.Cache.Redis;
using YPHF.Core.Orm.SqlSugar;
using YPHF.Core.Register.Consul;
using YPHF.Core.Trace.Zipkin;

#endregion

namespace YPHF.Core.Web;

/// <summary>
/// 基础微服务类，继承自MicroService
/// </summary>
/// <remarks></remarks>
public class BaseMicroService : MicroService
{
    /// <summary>
    /// 日志记录器实例
    /// </summary>
    private readonly ILog logger;

    /// <summary>
    /// 服务标题
    /// </summary>
    private readonly string title;

    /// <summary>
    /// XML文档列表
    /// </summary>
    private readonly List<string> xmls;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="title">服务标题</param>
    /// <param name="xmls">XML文档列表</param>
    public BaseMicroService(string title, List<string> xmls)
    {
        this.title = title;
        this.xmls = xmls;

        logger = BaseLogger.GetLogger();

        logger.Info("开始构建基础微服务");
    }

    /// <summary>
    /// 构建时的回调
    /// </summary>
    public Action<WebApplicationBuilder> OnBuild { get; set; } = default!;

    /// <summary>
    /// 启动时的回调
    /// </summary>
    public Action<WebApplication> OnStart { get; set; } = default!;

    /// <summary>
    /// 异步构建方法
    /// </summary>
    /// <param name="builder">Web应用构建器</param>
    /// <returns></returns>
    protected override async Task BuildAsync(WebApplicationBuilder builder)
    {
        // 调用基类的 BuildAsync 方法
        await base.BuildAsync(builder);

        var configuration = builder.Configuration;
        var services = builder.Services;

        logger.Info("开始添加Redis服务");
        // 添加Redis服务
        services.AddRedis(configuration);

        logger.Info("开始添加Consul服务");
        // 添加Consul服务
        services.AddConsul(configuration);

        logger.Info("开始添加Zipkin服务");
        // 添加Zipkin服务
        services.AddZipkin(configuration);

        logger.Info("开始添加SqlSugar服务");
        // 添加SqlSugar服务
        services.AddSqlSugger(configuration);

        logger.Info("开始添加Swagger服务");
        // 添加Swagger服务
        services.AddSwagger(title, xmls);

        logger.Info("开始执行构建回调");

        // 执行构建回调
        OnBuild?.Invoke(builder);
    }

    /// <summary>
    /// 异步启动方法
    /// </summary>
    /// <param name="app">Web应用</param>
    /// <returns></returns>
    protected override async Task StartAsync(WebApplication app)
    {
        // 调用基类的 StartAsync 方法
        await base.StartAsync(app);

        logger.Info("开始使用 Consul 中间件");
        // 使用 Consul 中间件
        await app.UseConsulAsync();

        logger.Info("开始使用 Zipkin 中间件");
        // 使用 Zipkin 中间件
        app.UseZipkin();

        logger.Info("开始使用 Swagger 仪表盘");
        // 使用 Swagger 仪表盘
        app.UseSwaggerDashboard();

        logger.Info("开执行启动回调");

        // 执行启动回调
        OnStart?.Invoke(app);
    }
}