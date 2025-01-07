/*
 *
 * ��Ȩ���� ����������
 * ��   �� : duhuifeng
 *
 */

#region

using YPHF.Core.Web;

#endregion

namespace YPHF.Auth.Service;

/// <summary>
/// ���������
/// </summary>
public class Program
{
    /// <summary>
    /// ������ڷ���
    /// </summary>
    /// <param name="args">�����в���</param>
    public static async Task Main(string[] args)
    {
        // XML�ĵ��б�
        var xmls = new List<string>
        {
            "YPHF.Core.*.xml",
            "YPHF.Auth.*.xml"
        };

        // ����΢����ʵ��
        var microService = new BaseMicroService("YPHF.Auth.Service", xmls)
        {
            // ���ù�����
            OnBuild = builder =>
            {
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                builder.UseAutoFac(new AutoFacConfig());
            }
        };

        // ����΢����
        await microService.RunAsync(args);
    }
}