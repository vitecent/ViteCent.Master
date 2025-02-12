/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Mvc;
using Template.Core.Data;

#endregion

namespace Template.Core.Web.Api;

/// <summary>
/// </summary>
/// <typeparam name="Args"></typeparam>
/// <typeparam name="Result"></typeparam>
public abstract class BaseApi<Args, Result> : ControllerBase
    where Args : BaseArgs
    where Result : BaseResult
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public abstract Task<Result> InvokeAsync(Args args);
}