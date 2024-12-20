/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Builder;
using YPHF.Core.Api.Swagger;
using YPHF.Core.Cache.Redis;
using YPHF.Core.Orm.SqlSugar;
using YPHF.Core.Register.Consul;
using YPHF.Core.Trace.Zipkin;

#endregion

namespace YPHF.Core.Web;

/// <summary>
/// </summary>
/// <remarks></remarks>
/// <param name="title"></param>
/// <param name="xmls"></param>
public class BaseMicroService(string title, List<string> xmls) : MicroService
{
    /// <summary>
    /// </summary>
    public Action<WebApplicationBuilder> OnBuild { get; set; } = default!;

    /// <summary>
    /// </summary>
    public Action<WebApplication> OnSatrt { get; set; } = default!;

    /// <summary>
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    protected override async Task BuildAsync(WebApplicationBuilder builder)
    {
        var configuration = builder.Configuration;
        var services = builder.Services;

        services.AddRedis(configuration);
        services.AddConsul(configuration);
        services.AddZipkin(configuration);
        services.AddSqlSugger(configuration);
        services.AddSwagger(title, xmls);

        OnBuild?.Invoke(builder);

        await base.BuildAsync(builder);
    }

    /// <summary>
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    protected override async Task StartAsync(WebApplication app)
    {
        await app.UseConsulAsync();
        app.UseZipkin();
        app.UseSwaggerDashboard();

        OnSatrt?.Invoke(app);

        await base.StartAsync(app);
    }
}