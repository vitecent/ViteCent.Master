#region

using ViteCent.Core.Web;

#endregion

namespace ViteCent.Gateway.Api;

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
            "ViteCent.Core.*.xml",
            "ViteCent.Gateway.*.xml"
        };

        var microService = new BaseMicroService("ViteCent.Gateway.Service", xmls)
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