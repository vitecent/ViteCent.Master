/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YPHF.Core.Cache;
using YPHF.Core.Data;

#endregion

namespace YPHF.Core.Register.Consul;

/// <summary>
///     Class ConsulExtensions.
/// </summary>
public static class ConsulExtensions
{
    /// <summary>
    ///     Adds the consul.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <param name="configuration">The configuration.</param>
    /// <returns>IServiceCollection.</returns>
    /// <exception cref="System.Exception">ICache is need</exception>
    /// <exception cref="System.Exception">Register</exception>
    public static IServiceCollection AddConsul(this IServiceCollection services, IConfiguration configuration)
    {
        var serviceProvider = services.BuildServiceProvider();

        var cache = serviceProvider.GetService<IBaseCache>() ?? throw new Exception("Three Must Be ICache");

        var uri = configuration["Register"];

        if (string.IsNullOrWhiteSpace(uri)) throw new Exception("Appsettings Must Be Register");

        services.AddTransient<IRegister>(x => new ConsulRegister(uri, cache));

        return services;
    }

    /// <summary>
    ///     Uses the consul.
    /// </summary>
    /// <param name="app">The app.</param>
    /// <returns>IApplicationBuilder.</returns>
    /// <exception cref="System.Exception">ICache is need</exception>
    /// <exception cref="System.Exception">Register</exception>
    /// <exception cref="System.Exception">ServiceConfig.Name</exception>
    /// <exception cref="System.Exception">ServiceConfig.Port</exception>
    /// <exception cref="System.Exception">ServiceConfig.Address</exception>
    public static async Task<IApplicationBuilder> UseConsulAsync(this WebApplication app)
    {
        var serviceProvider = app.Services;

        var cache = serviceProvider.GetService<IBaseCache>() ?? throw new Exception("Three Must Be ICache");

        var configuration = app.Configuration;

        var uri = configuration["Register"];

        if (string.IsNullOrWhiteSpace(uri)) throw new Exception("Appsettings Must Be Register");

        var serviceName = configuration["Service:Name"];

        if (string.IsNullOrWhiteSpace(serviceName)) throw new Exception("Appsettings Must Be ServiceConfig.Name");

        var flagServicePort = int.TryParse(configuration["Service:Port"], out var servicePort);

        if (!flagServicePort || servicePort < 1) throw new Exception("Appsettings Must Be ServiceConfig.Port");

        var serviceId = configuration["Service:Id"];

        if (string.IsNullOrWhiteSpace(serviceId)) serviceId = $"{serviceName}:{servicePort}";

        var address = configuration["Service:Address"];

        if (string.IsNullOrWhiteSpace(address)) throw new Exception("Appsettings Must Be ServiceConfig.Address");

        var flagTimeout = int.TryParse(configuration["Service:Timeout"], out var timeout);

        if (!flagTimeout || timeout < 1) timeout = 5;

        var flagDeregister = int.TryParse(configuration["Service:Deregister"], out var deregister);

        if (!flagDeregister || deregister < 1) deregister = 30;

        _ = bool.TryParse(configuration["Service:Https"], out var iShttps);

        var check = configuration["Service:Check"];

        if (string.IsNullOrWhiteSpace(check)) check = Const.Check;

        var service = new ServiceConfig
        {
            Id = serviceId,
            Name = serviceName,
            Port = servicePort,
            Address = address,
            Timeout = timeout,
            Deregister = deregister,
            IsHttps = iShttps,
            Check = check
        };

        await new ConsulRegister(uri, cache).RegisterAsync(service);

        if (check == Const.Check) app.MapGet(check, () => new BaseResult());

        var lifetime = app.Lifetime;

        lifetime.ApplicationStopping.Register(async () =>
        {
            await new ConsulRegister(uri, cache).DeregisterAsync(serviceId);
        });

        return app;
    }
}