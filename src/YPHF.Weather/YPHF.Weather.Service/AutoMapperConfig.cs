/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Core.Web;
using YPHF.Weather.Dto.Home;
using YPHF.Weather.Model;

#endregion

namespace YPHF.Weather.Service;

/// <summary>
/// </summary>
public class AutoMapperConfig : BaseMapperConfig
{
    /// <summary>
    /// </summary>
    public override void Map()
    {
        CreateMap<HomeModel, HomeResult>();
        CreateMap<HomeResult, HomeModel>();
    }
}