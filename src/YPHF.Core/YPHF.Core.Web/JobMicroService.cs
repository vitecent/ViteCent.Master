/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Builder;
using Quartz;
using YPHF.Core.Api.Swagger;
using YPHF.Core.Cache.Redis;
using YPHF.Core.Job.Quartz;
using YPHF.Core.Orm.SqlSugar;
using YPHF.Core.Register.Consul;
using YPHF.Core.Trace.Zipkin;

namespace YPHF.Core.Web
{
    /// <summary>
    /// </summary>
    public class JobMicroService(string title, List<string> xmls) : MicroService
    {
        /// <summary>
        /// </summary>
        private IScheduler scheduler = default!;

        /// <summary>
        /// </summary>
        public Action<WebApplicationBuilder> OnBuild { get; set; } = default!;

        /// <summary>
        /// </summary>
        public Action<IScheduler> OnRegist { get; set; } = default!;

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
            services.AddSqlSugger(configuration);
            services.AddSwagger(title, xmls);

            scheduler = await services.AddQuarzAsync();

            var job = new Thread(() => OnRegist?.Invoke(scheduler))
            {
                IsBackground = true,
                Priority = ThreadPriority.Highest,
                Name = "Job"
            };

            job.Start();

            OnBuild?.Invoke(builder);

            await base.BuildAsync(builder);
        }

        /// <summary>
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        protected override async Task StartAsync(WebApplication app)
        {
            if (scheduler != null)
            {
                app.UseQuarz(scheduler);
            }

            await app.UseConsulAsync();
            app.UseZipkin();
            app.UseSwaggerDashboard();

            await base.StartAsync(app);
        }
    }
}