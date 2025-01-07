/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Core.Web;

#endregion

namespace YPHF.Auth.Service;

/// <summary>
/// 程序入口类
/// </summary>
public class Program
{
    /// <summary>
    /// 程序入口方法
    /// </summary>
    /// <param name="args">命令行参数</param>
    public static async Task Main(string[] args)
    {
        // XML文档列表
        var xmls = new List<string>
        {
            "YPHF.Core.*.xml",
            "YPHF.Auth.*.xml"
        };

        // 创建微服务实例
        var microService = new BaseMicroService("YPHF.Auth.Service", xmls)
        {
            // 配置构建器
            OnBuild = builder =>
            {
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                builder.UseAutoFac(new AutoFacConfig());
            }
        };

        // 运行微服务
        await microService.RunAsync(args);
    }
}