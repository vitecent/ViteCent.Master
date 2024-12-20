/*
 *
 * ��Ȩ���� ����������
 * ��   �� : duhuifeng
 *
 */

#region

using YPHF.Core.Web;

#endregion

namespace YPHF.Airspace.Service;

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
            //"YPHF.Airspace.Service"
        };

        // ����������΢����ʵ��
        var microService = new BaseMicroService("YPHF.Airspace.Service", xmls)
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