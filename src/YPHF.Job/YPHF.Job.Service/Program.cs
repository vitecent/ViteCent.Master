/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Quartz;
using YPHF.Core.Web;
using YPHF.Job.Service.Jobs;

#endregion

namespace YPHF.Job.Service;

/// <summary>
/// 程序入口类
/// </summary>
public class Program
{
    /// <summary>
    /// 程序入口方法
    /// </summary>
    /// <param name="args">命令行参数</param>
    public static async Task Main(string[] args)
    {
        // XML 配置文件列表
        var xmls = new List<string>
        {
            //"YPHF.Job.Service"
        };

        // 创建并配置 JobMicroService 实例
        var microService = new JobMicroService("YPHF.Job.Service", xmls)
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
                // 创建 HomeJob 实例
                var job = JobBuilder.Create<HomeJob>()
                    .WithIdentity("HomeJob", "HomeGroup")
                    .Build();

                // 创建触发器，设置为每 5 秒执行一次
                var trigger = TriggerBuilder.Create()
                    .WithIdentity("HomeJob", "HomeGroup")
                    .StartNow()
                    .WithCronSchedule("0/5 * * * * ?")
                    .Build();

                // 将作业和触发器注册到调度器
                await scheduler.ScheduleJob(job, trigger);
            }
        };

        // 运行微服务
        await microService.RunAsync(args);
    }
}