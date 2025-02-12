/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Template.Core.Web;

#endregion

namespace Template.Gateway.Api;

/// <summary>
/// </summary>
public class Program
{
    /// <summary>
    /// </summary>
    public static async Task Main(string[] args)
    {
        var xmls = new List<string>
        {
            "Template.Core.*.xml",
            "Template.Gateway.*.xml"
        };

        var microService = new BaseMicroService("Template.Gateway.Service", xmls)
        {
            OnBuild = builder =>
            {
                builder.Services.AddGateway();
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                builder.UseAutoFac(new AutoFacConfig());
            },
            OnStart = app => { app.UseGateway(); }
        };

        await microService.RunAsync(args);
    }
}