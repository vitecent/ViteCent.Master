#region

using Quartz;
using ViteCent.Core;
using ViteCent.Core.Cache;
using ViteCent.Core.Data;
using ViteCent.Core.Register;

#endregion

namespace ViteCent.Job.Api.Jobs;

/// <summary>
/// </summary>
public class SimpleJob : IJob
{
    /// <summary>
    /// </summary>
    private readonly IBaseCache _cache;

    /// <summary>
    /// </summary>
    private readonly ILogger<SimpleJob> _logger;

    /// <summary>
    /// </summary>
    private readonly IRegister _register;

    /// <summary>
    /// </summary>
    /// <param name="register"></param>
    /// <param name="cache"></param>
    /// <param name="logger"></param>
    public SimpleJob(IRegister register, IBaseCache cache, ILogger<SimpleJob> logger)
    {
        _register = register;
        _cache = cache;
        _logger = logger;
    }

    /// <summary>
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task Execute(IJobExecutionContext context)
    {
        var services = await _register.DiscoverAsync();

        _logger.LogInformation($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}获取到{services.Count}个 服务");

        if (services.Count != 0) _cache.SetString(Const.RegistServices, services.ToJson(), TimeSpan.FromMinutes(2));
    }
}