/*
 *
 * ��Ȩ���� ����������
 * ��   �� : duhuifeng
 *
 */

#region

using YPHF.Core.Web;

#endregion

namespace YPHF.Files.Service;

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
            "YPHF.Files.*.xml"
        };

        var microService = new FilesMicroService("YPHF.Files.Service", xmls);
        await microService.RunAsync(args);
    }
}