/*
 *
 * ��Ȩ���� ����������
 * ��   �� : duhuifeng
 *
 */

#region

using YPHF.Core.Web;

#endregion

namespace YPHF.Statistics.Service;

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
            "YPHF.Core.*.xml",
            "YPHF.Statistics.*.xml"
        };

        var microService = new BaseMicroService("YPHF.Statistics.Service", xmls)
        {
            OnBuild = builder =>
            {
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                builder.UseAutoFac(new AutoFacConfig());
            }
        };

        await microService.RunAsync(args);
    }
}