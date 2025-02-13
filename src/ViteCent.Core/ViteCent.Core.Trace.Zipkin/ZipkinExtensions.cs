﻿/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ViteCent.Core.Data;
using zipkin4net;
using zipkin4net.Middleware;
using zipkin4net.Tracers.Zipkin;
using zipkin4net.Transport.Http;

#endregion

namespace ViteCent.Core.Trace.Zipkin;

/// <summary>
///     Zipkin 扩展方法类。
/// </summary>
public static class ZipkinExtensions
{
    /// <summary>
    ///     添加 Zipkin 服务。
    /// </summary>
    /// <param name="services">服务集合。</param>
    /// <param name="configuration">配置。</param>
    /// <returns>服务集合。</returns>
    public static IServiceCollection AddZipkin(this IServiceCollection services, IConfiguration configuration)
    {
        var isDapr = configuration["Environment"] ?? default!;

        if (isDapr != "Dapr")
        {
            var logger = BaseLogger.GetLogger();

            // 设置采样率
            TraceManager.SamplingRate = 1.0f;

            var loggerFactory = new LoggerFactory();
            var log = new TracingLogger(loggerFactory, "ZipkinExtensions");

            var uri = configuration["Trace"];

            logger.Info($"Zipkin RegisterUri ：{uri}");

            if (string.IsNullOrWhiteSpace(uri)) throw new Exception("Appsettings Must Be Trace");

            // 配置 Zipkin 发送器和追踪器
            var httpSender = new HttpZipkinSender(uri, "application/json");
            var tracer = new ZipkinTracer(httpSender, new JSONSpanSerializer());

            // 注册追踪器并启动追踪管理器
            TraceManager.RegisterTracer(tracer);
            TraceManager.Start(log);
        }

        return services;
    }

    /// <summary>
    ///     使用 Zipkin 中间件。
    /// </summary>
    /// <param name="app">应用程序构建器。</param>
    /// <returns>应用程序构建器。</returns>
    public static IApplicationBuilder UseZipkin(this WebApplication app)
    {
        var configuration = app.Configuration;

        var isDapr = configuration["Environment"] ?? default!;

        if (isDapr != "Dapr")
        {
            var serviceName = configuration["Service:Name"];

            var check = configuration["Service:Check"];

            if (string.IsNullOrWhiteSpace(check)) check = Const.Check;

            // 使用 Zipkin 追踪中间件
            app.UseTracing(serviceName, null, x => { return x != check; });

            var lifetime = app.Lifetime;

            // 注册应用程序停止事件以停止追踪管理器
            lifetime.ApplicationStopping.Register(() => { TraceManager.Stop(); });
        }

        return app;
    }
}