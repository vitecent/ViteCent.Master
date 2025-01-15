/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Core.Web;
using YPHF.Service.Dto.Home;
using YPHF.Service.Model;

#endregion

namespace YPHF.Service.Service;

/// <summary>
/// AutoMapper配置类，继承自BaseMapperConfig
/// </summary>
public class AutoMapperConfig : BaseMapperConfig
{
    /// <summary>
    /// 配置映射关系的方法
    /// </summary>
    public override void Map()
    {
        // 配置HomeModel到HomeResult的映射
        CreateMap<HomeModel, HomeResult>();
        // 配置HomeResult到HomeModel的映射
        CreateMap<HomeResult, HomeModel>();
    }
}