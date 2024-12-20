/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Quartz;
using YPHF.Core.Web;
using YPHF.Job.Service.Jobs;

namespace YPHF.Job.Service
{
    /// <summary>
    /// </summary>
    public class Program
    {
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        public static async Task Main(string[] args)
        {
            var xmls = new List<string>()
            {
                //"YPHF.Job.Service"
            };

            var microService = new JobMicroService("YPHF.Job.Service", xmls)
            {
                OnBuild = (builder) =>
                {
                    builder.UseAutoMapper(typeof(AutoMapperConfig));
                    builder.UseAutoFac(new AutoFacConfig());
                },
                OnRegist = async (scheduler) =>
                {
                    var job = JobBuilder.Create<HomeJob>()
                        .WithIdentity("HomeJob", "HomeGroup")
                        .Build();

                    var trigger = TriggerBuilder.Create()
                        .WithIdentity("HomeJob", "HomeGroup")
                        .StartNow()
                        .WithCronSchedule("0/5 * * * * ?")
                        .Build();

                    await scheduler.ScheduleJob(job, trigger);
                }
            };

            await microService.RunAsync(args);
        }
    }
}