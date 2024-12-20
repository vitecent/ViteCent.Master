/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

using System.IO.Compression;
using YPHF.Core.Data;
using YPHF.Core.Logging.Log4Net;
using YPHF.Core.Web.Filter;

#endregion

namespace YPHF.Core.Web;

/// <summary>
/// </summary>
public abstract class MicroService
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public virtual async Task RunAsync(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;
        configuration.SetBasePath(Directory.GetCurrentDirectory());

        await ConfigAsync(configuration);

        //Builder
        var services = builder.Services;
        services.AddLog4Net();

        services.AddResponseCompression();
        services.Configure<GzipCompressionProviderOptions>(options => { options.Level = CompressionLevel.Fastest; });
        services.AddEndpointsApiExplorer();

        services.AddControllers(options => { options.Filters.Add(new BaseExceptionFilter()); }).AddNewtonsoftJson(
            options =>
            {
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).AddDapr();

        await BuildAsync(builder);

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        BaseHttpContext.Services = services;

        //App
        var app = builder.Build();

        await StartAsync(app);

        var lifetime = app.Lifetime;

        lifetime.ApplicationStopping.Register(async () => { await StopAsync(); });

        if (app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/home/error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }

    /// <summary>
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    protected virtual async Task BuildAsync(WebApplicationBuilder builder)
    {
        await Task.CompletedTask;
    }

    /// <summary>
    /// </summary>
    /// <param name="configuration"></param>
    /// <returns></returns>
    protected virtual async Task ConfigAsync(IConfiguration configuration)
    {
        await Task.CompletedTask;
    }

    /// <summary>
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    protected virtual async Task StartAsync(WebApplication app)
    {
        await Task.CompletedTask;
    }

    /// <summary>
    /// </summary>
    /// <returns></returns>
    protected virtual async Task StopAsync()
    {
        await Task.CompletedTask;
    }
}