/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using AutoMapper;

#endregion

namespace YPHF.Core.Web;

/// <summary>
/// </summary>
public abstract class BaseMapperConfig : Profile
{
    /// <summary>
    /// </summary>
    public BaseMapperConfig()
    {
        Map();
    }

    /// <summary>
    /// </summary>
    public abstract void Map();
}