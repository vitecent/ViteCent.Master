#region

using log4net;
using Quartz;
using ViteCent.Core;

#endregion

namespace ViteCent.Job.Api.Jobs;

/// <summary>
/// </summary>
public class SimpleJob : IJob
{
    /// <summary>
    ///     日志记录器实例。
    /// </summary>
    private readonly ILog logger;

    /// <summary>
    /// </summary>
    public SimpleJob()
    {
        logger = BaseLogger.GetLogger();
    }

    /// <summary>
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task Execute(IJobExecutionContext context)
    {
        logger.Info($"SimpleJob : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        await Task.CompletedTask;
    }
}