/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YPHF.Core.Data;

#endregion

namespace YPHF.Core.Web.Api;

/// <summary>
/// </summary>
public abstract class BaseFileApi<Args, Result> : ControllerBase
    where Args : IFormFile
    where Result : BaseResult
{
    /// <summary>
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public abstract Task<Result> InvokeAsync(Args file);
}