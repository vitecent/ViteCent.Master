/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Auth.Dto.Home;
using YPHF.Core.Data;

#endregion

namespace YPHF.Auth.Bll;

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