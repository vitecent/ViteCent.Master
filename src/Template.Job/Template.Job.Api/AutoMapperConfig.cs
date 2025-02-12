/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Template.Core.Web;
using Template.Job.Entity;
using Template.Job.Infrastructure.Home;

#endregion

namespace Template.Job.Api;

/// <summary>
/// </summary>
public class AutoMapperConfig : BaseMapperConfig
{
    /// <summary>
    /// </summary>
    public override void Map()
    {
        CreateMap<HomeEntity, HomeResult>();
        CreateMap<HomeResult, HomeEntity>();
    }
}