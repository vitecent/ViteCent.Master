/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using Quartz;
using ViteCent.Core.Web;
using ViteCent.Job.Api.Jobs;

#endregion

namespace ViteCent.Job.Api;

/// <summary>
///     程序入口类
/// </summary>
public class Program
{
    /// <summary>
    ///     程序入口方法
    /// </summary>
    /// <param name="args">命令行参数</param>
    public static async Task Main(string[] args)
    {
        // XML 配置文件列表
        var xmls = new List<string>
        {
            "ViteCent.Core.*.xml",
            "ViteCent.Job.*.xml"
        };

        // 创建并配置 JobMicroService 实例
        var microService = new JobMicroService("ViteCent.Job.Service", xmls)
        {
            OnBuild = builder =>
            {
                // 使用 AutoMapper 配置
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                // 使用 AutoFac 配置
                builder.UseAutoFac(new AutoFacConfig());
            },
            OnRegist = async scheduler =>
            {
                // 创建 SimpleJob 实例
                var job = JobBuilder.Create<SimpleJob>()
                    .WithIdentity("SimpleJob", "SimpleGroup")
                    .Build();

                // 创建触发器，设置为每 5 秒执行一次
                var trigger = TriggerBuilder.Create()
                    .WithIdentity("SimpleJob", "SimpleGroup")
                    .StartNow()
                    .WithCronSchedule("0 0/1 * * * ? ")
                    .Build();

                // 将作业和触发器注册到调度器
                await scheduler.ScheduleJob(job, trigger);
            }
        };

        // 运行微服务
        await microService.RunAsync(args);
    }
}