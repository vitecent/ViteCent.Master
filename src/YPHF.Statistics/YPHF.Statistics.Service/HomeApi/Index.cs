/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Mvc;
using YPHF.Core.Data;
using YPHF.Core.Web.Api;

#endregion

namespace YPHF.Statistics.Service.HomeApi;

/// <summary>
/// </summary>
[ApiController]
public class Index : BaseApi<BaseArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Index")]
    public override async Task<BaseResult> InvokeAsync([FromBody] BaseArgs args)
    {
        return await Task.FromResult(new BaseResult("Statistics"));
    }
}