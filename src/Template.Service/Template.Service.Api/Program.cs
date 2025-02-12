/*
 *
 * ��Ȩ���� ����������
 * ��   �� : duhuifeng
 *
 */

#region

using Template.Core.Web;

#endregion

namespace Template.Service.Api;

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
            "Template.Core.*.xml",
            "Template.Service.*.xml"
        };

        // ����������΢����ʵ��
        var microService = new BaseMicroService("Template.Service.Service", xmls)
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