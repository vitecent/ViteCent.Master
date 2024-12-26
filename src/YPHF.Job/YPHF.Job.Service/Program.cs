/*
 *
 * ��Ȩ���� ����������
 * ��   �� : duhuifeng
 *
 */

#region

using Quartz;
using YPHF.Core.Web;
using YPHF.Job.Service.Jobs;

#endregion

namespace YPHF.Job.Service;

/// <summary>
/// ���������
/// </summary>
public class Program
{
    /// <summary>
    /// ������ڷ���
    /// </summary>
    /// <param name="args">�����в���</param>
    public static async Task Main(string[] args)
    {
        // XML �����ļ��б�
        var xmls = new List<string>
        {
            //"YPHF.Job.Service"
        };

        // ���������� JobMicroService ʵ��
        var microService = new JobMicroService("YPHF.Job.Service", xmls)
        {
            OnBuild = builder =>
            {
                // ʹ�� AutoMapper ����
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                // ʹ�� AutoFac ����
                builder.UseAutoFac(new AutoFacConfig());
            },
            OnRegist = async scheduler =>
            {
                // ���� HomeJob ʵ��
                var job = JobBuilder.Create<HomeJob>()
                    .WithIdentity("HomeJob", "HomeGroup")
                    .Build();

                // ����������������Ϊÿ 5 ��ִ��һ��
                var trigger = TriggerBuilder.Create()
                    .WithIdentity("HomeJob", "HomeGroup")
                    .StartNow()
                    .WithCronSchedule("0/5 * * * * ?")
                    .Build();

                // ����ҵ�ʹ�����ע�ᵽ������
                await scheduler.ScheduleJob(job, trigger);
            }
        };

        // ����΢����
        await microService.RunAsync(args);
    }
}