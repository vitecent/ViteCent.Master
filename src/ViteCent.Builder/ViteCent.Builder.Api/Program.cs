#region

using ViteCent.Core.Web;

#endregion

namespace ViteCent.Builder.Api;

/// <summary>
///     ��������ࡣ
/// </summary>
public class Program
{
    /// <summary>
    ///     Ӧ�ó��������ڵ㡣
    /// </summary>
    /// <param name="args">�����в�����</param>
    public static async Task Main(string[] args)
    {
        // ����һ������ XML �ļ�·�����б�
        var xmls = new List<string>
        {
            "ViteCent.Core.*.xml",
            "ViteCent.Builder.*.xml"
        };

        // ����������΢����ʵ��
        var microService = new BaseMicroService("ViteCent.Builder.Service", xmls)
        {
            OnBuild = builder =>
            {
                // ʹ�� AutoMapper ����
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                // ʹ�� AutoFac ����
                builder.UseAutoFac(new AutoFacConfig());
            }
        };

        // ����΢����
        await microService.RunAsync(args);
    }
}