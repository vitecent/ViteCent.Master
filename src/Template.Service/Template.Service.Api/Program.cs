/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Template.Core.Web;

#endregion

namespace Template.Service.Api;

/// <summary>
///     程序入口类。
/// </summary>
public class Program
{
    /// <summary>
    ///     应用程序的主入口点。
    /// </summary>
    /// <param name="args">命令行参数。</param>
    public static async Task Main(string[] args)
    {
        // 定义一个包含 XML 文件路径的列表
        var xmls = new List<string>
        {
            "Template.Core.*.xml",
            "Template.Service.*.xml"
        };

        // 创建并配置微服务实例
        var microService = new BaseMicroService("Template.Service.Service", xmls)
        {
            OnBuild = builder =>
            {
                // 使用 AutoMapper 配置
                builder.UseAutoMapper(typeof(AutoMapperConfig));
                // 使用 AutoFac 配置
                builder.UseAutoFac(new AutoFacConfig());
            }
        };

        // 运行微服务
        await microService.RunAsync(args);
    }
}