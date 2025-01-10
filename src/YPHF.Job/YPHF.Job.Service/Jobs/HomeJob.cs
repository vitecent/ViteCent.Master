/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Quartz;
using YPHF.Core;
using YPHF.Core.Cache;
using YPHF.Core.Data;
using YPHF.Core.Register;

#endregion

namespace YPHF.Job.Service.Jobs;

/// <summary>
/// </summary>
public class HomeJob : IJob
{
    /// <summary>
    ///
    /// </summary>
    private readonly IBaseCache cache;

    /// <summary>
    ///
    /// </summary>
    private readonly ILogger<HomeJob> logger;

    /// <summary>
    ///
    /// </summary>
    private readonly IRegister register;

    /// <summary>
    ///
    /// </summary>
    /// <param name="register"></param>
    /// <param name="cache"></param>
    /// <param name="logger"></param>
    public HomeJob(IRegister register, IBaseCache cache, ILogger<HomeJob> logger)
    {
        this.register = register;
        this.cache = cache;
        this.logger = logger;
    }

    /// <summary>
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task Execute(IJobExecutionContext context)
    {
        var services = await register.DiscoverAsync();

        logger.LogInformation($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}获取到{services.Count}个服务");

        if (services.Count != 0)
        {
            cache.SetString(Const.RegistServices, services.ToJson(), TimeSpan.FromMinutes(2));
        }
    }
}