#region

using Quartz;
using ViteCent.Core.Web;
using ViteCent.Job.Api.Jobs;

#endregion

namespace ViteCent.Job.Api;

/// <summary>
///     ���������
/// </summary>
public class Program
{
    /// <summary>
    ///     ������ڷ���
    /// </summary>
    /// <param name="args">�����в���</param>
    public static async Task Main(string[] args)
    {
        // XML �����ļ��б�
        var xmls = new List<string>
        {
            "ViteCent.Core.*.xml",
            "ViteCent.Job.*.xml"
        };

        // ���������� JobMicroService ʵ��
        var microService = new JobMicroService("ViteCent.Job.Service", xmls)
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
                // ���� SimpleJob ʵ��
                var job = JobBuilder.Create<SimpleJob>()
                    .WithIdentity("SimpleJob", "SimpleGroup")
                    .Build();

                // ����������������Ϊÿ 5 ��ִ��һ��
                var trigger = TriggerBuilder.Create()
                    .WithIdentity("SimpleJob", "SimpleGroup")
                    .StartNow()
                    .WithCronSchedule("0 0/1 * * * ? ")
                    .Build();

                // ����ҵ�ʹ�����ע�ᵽ������
                await scheduler.ScheduleJob(job, trigger);
            }
        };

        // ����΢����
        await microService.RunAsync(args);
    }
}