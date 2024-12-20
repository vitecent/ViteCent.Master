/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Airspace.Dto.Home;
using YPHF.Airspace.Model;
using YPHF.Core.Web;

#endregion

namespace YPHF.Airspace.Service;

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