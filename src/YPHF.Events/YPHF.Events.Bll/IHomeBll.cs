/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Core.Data;
using YPHF.Events.Dto.Home;

#endregion

namespace YPHF.Events.Bll;

/// <summary>
/// </summary>
public interface IHomeBll
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    Task<PageResult<HomeResult>> PageAsync(HomeArgs args);
}