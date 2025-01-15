using NuGet.Server;
using NuGet.Server.Infrastructure;
using NuGet.Server.V2;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Routing;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(YPHF.Nuget.Service.App_Start.NuGetODataConfig), "Start")]

namespace YPHF.Nuget.Service.App_Start
{
    public static class NuGetODataConfig
    {
        public static void Start()
        {
            ServiceResolver.SetServiceResolver(new DefaultServiceResolver());

            var config = GlobalConfiguration.Configuration;

            NuGetV2WebApiEnabler.UseNuGetV2WebApiFeed(
                config,
                "NuGetDefault",
                "nuget",
                "PackagesOData",
                true);

            config.Services.Replace(typeof(IExceptionLogger), new TraceExceptionLogger());

            // Trace.Listeners.Add(new TextWriterTraceListener(HostingEnvironment.MapPath("~/NuGet.Server.log")));
            // Trace.AutoFlush = true;

            config.Routes.MapHttpRoute(
                "NuGetDefault_ClearCache",
                "nuget/clear-cache",
                new { controller = "PackagesOData", action = "ClearCache" },
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Get) }
            );
        }
    }
}