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
using YPHF.Core.Register.Consul;
using YPHF.Core.Trace.Zipkin;

#endregion

namespace YPHF.Core.Web;

/// <summary>
/// 文件微服务类，继承自 MicroService 基类
/// </summary>
public class FilesMicroService : MicroService
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
    /// XML 文档列表
    /// </summary>
    private readonly List<string> xmls;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="title">服务标题</param>
    /// <param name="xmls">XML文档列表</param>
    public FilesMicroService(string title, List<string> xmls)
    {
        this.title = title;
        this.xmls = xmls;

        logger = BaseLogger.GetLogger();

        logger.Info("开始构建文档微服务");
    }

    /// <summary>
    /// 构建微服务，添加所需的服务
    /// </summary>
    /// <param name="builder">Web 应用程序构建器</param>
    /// <returns>异步任务</returns>
    protected override async Task BuildAsync(WebApplicationBuilder builder)
    {
        // 调用基类的 BuildAsync 方法
        await base.BuildAsync(builder);

        var configuration = builder.Configuration;
        var services = builder.Services;

        logger.Info("开始添加 Redis 缓存服务");
        // 添加 Redis 缓存服务
        services.AddRedis(configuration);

        logger.Info("开始添加 Consul 注册服务");
        // 添加 Consul 注册服务
        services.AddConsul(configuration);

        logger.Info("开始添加 Zipkin 链路追踪服务");
        // 添加 Zipkin 链路追踪服务
        services.AddZipkin(configuration);

        logger.Info("开始添加 Swagger 文档服务");
        // 添加 Swagger 文档服务
        services.AddSwagger(title, xmls);
    }

    /// <summary>
    /// 启动微服务，配置中间件
    /// </summary>
    /// <param name="app">Web 应用程序</param>
    /// <returns>异步任务</returns>
    protected override async Task StartAsync(WebApplication app)
    {
        // 调用基类的 StartAsync 方法
        await base.StartAsync(app);

        logger.Info("开始使用 Consul 注册中间件");
        // 使用 Consul 注册中间件
        await app.UseConsulAsync();

        logger.Info("开始使用 Zipkin 链路追踪中间件");
        // 使用 Zipkin 链路追踪中间件
        app.UseZipkin();

        logger.Info("开始映射静态资源");
        // 映射静态资源
        app.MapStaticAssets();

        logger.Info("开始使用 Swagger 仪表板");
        // 使用 Swagger 仪表板
        app.UseSwaggerDashboard();
    }
}