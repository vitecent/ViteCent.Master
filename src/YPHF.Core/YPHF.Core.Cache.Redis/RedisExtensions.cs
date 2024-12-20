/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

#endregion

namespace YPHF.Core.Cache.Redis;

/// <summary>
///     Class RedisExtensions.
/// </summary>
public static class RedisExtensions
{
    /// <summary>
    ///     Adds the redis.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <param name="configuration">The configuration.</param>
    /// <returns>IServiceCollection.</returns>
    /// <exception cref="System.Exception">Cache</exception>
    public static IServiceCollection AddRedis(this IServiceCollection services, IConfiguration configuration)
    {
        var strConn = configuration["Cache"];

        if (string.IsNullOrWhiteSpace(strConn)) throw new Exception("Appsettings Must Be Cache");

        services.AddTransient<IBaseCache>(x => new RedisCache(strConn));

        return services;
    }
}