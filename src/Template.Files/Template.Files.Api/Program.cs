#region

using Template.Core.Web;

#endregion

namespace Template.Files.Api;

/// <summary>
/// </summary>
public class Program
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    public static async Task Main(string[] args)
    {
        var xmls = new List<string>
        {
            "Template.Core.*.xml",
            "Template.Files.*.xml"
        };

        var microService = new FilesMicroService("Template.Files.Service", xmls);
        await microService.RunAsync(args);
    }
}