/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using YPHF.Core.Data;
using zipkin4net;
using zipkin4net.Middleware;
using zipkin4net.Tracers.Zipkin;
using zipkin4net.Transport.Http;

namespace YPHF.Core.Trace.Zipkin
{
    /// <summary>
    /// </summary>
    public static class ZipkinExtensions
    {
        /// <summary>
        /// Adds the consul.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>IServiceCollection.</returns>
        public static IServiceCollection AddZipkin(this IServiceCollection services, IConfiguration configuration)
        {
            var isDapr = configuration["Environment"] ?? "";

            if (isDapr != "Dapr")
            {
                TraceManager.SamplingRate = 1.0f;

                var loggerFactory = new LoggerFactory();
                var logger = new TracingLogger(loggerFactory, "zipkin4net");

                var traceUri = configuration["Trace"];

                if (string.IsNullOrWhiteSpace(traceUri))
                {
                    throw new Exception("Appsettings Must Be Trace");
                }

                var httpSender = new HttpZipkinSender(traceUri, "application/json");
                var tracer = new ZipkinTracer(httpSender, new JSONSpanSerializer());

                TraceManager.RegisterTracer(tracer);
                TraceManager.Start(logger);
            }

            return services;
        }

        /// <summary>
        /// Uses the consul.
        /// </summary>
        /// <param name="app">The app.</param>
        /// <returns>IApplicationBuilder.</returns>
        public static IApplicationBuilder UseZipkin(this WebApplication app)
        {
            var configuration = app.Configuration;

            var isDapr = configuration["Environment"] ?? "";

            if (isDapr != "Dapr")
            {
                var serviceName = configuration["Service:Name"];

                var check = configuration["Service:Check"];

                if (string.IsNullOrWhiteSpace(check))
                {
                    check = Const.Check;
                }

                app.UseTracing(serviceName, null, x =>
                {
                    return x != check;
                });

                var lifetime = app.Lifetime;

                lifetime.ApplicationStopping.Register(() =>
                {
                    TraceManager.Stop();
                });
            }

            return app;
        }
    }
}