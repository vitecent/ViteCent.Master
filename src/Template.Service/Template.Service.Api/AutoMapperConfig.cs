/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Template.Core.Web;
using Template.Service.Entity;
using Template.Service.Infrastructure.Home;

#endregion

namespace Template.Service.Api;

/// <summary>
///     AutoMapper配置类，继承自BaseMapperConfig
/// </summary>
public class AutoMapperConfig : BaseMapperConfig
{
    /// <summary>
    ///     配置映射关系的方法
    /// </summary>
    public override void Map()
    {
        // 配置HomeEntity到HomeResult的映射
        CreateMap<HomeEntity, HomeResult>();
        // 配置HomeResult到HomeEntity的映射
        CreateMap<HomeResult, HomeEntity>();
    }
}