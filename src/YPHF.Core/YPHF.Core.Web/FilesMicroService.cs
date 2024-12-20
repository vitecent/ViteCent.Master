/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Builder;
using YPHF.Core.Api.Swagger;
using YPHF.Core.Cache.Redis;
using YPHF.Core.Register.Consul;
using YPHF.Core.Trace.Zipkin;

namespace YPHF.Core.Web
{
    /// <summary>
    /// </summary>
    public class FilesMicroService(string title, List<string> xmls) : MicroService
    {
        /// <summary>
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        protected override async Task BuildAsync(WebApplicationBuilder builder)
        {
            var configuration = builder.Configuration;
            var services = builder.Services;

            services.AddRedis(configuration);
            services.AddConsul(configuration);
            services.AddZipkin(configuration);
            services.AddSwagger(title, xmls);

            await base.BuildAsync(builder);
        }

        /// <summary>
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        protected override async Task StartAsync(WebApplication app)
        {
            await app.UseConsulAsync();
            app.UseZipkin();
            app.MapStaticAssets();
            app.UseSwaggerDashboard();

            await base.StartAsync(app);
        }
    }
}