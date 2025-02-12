/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Mvc;
using Template.Core.Data;
using Template.Core.Web.Api;
using Template.Job.Application;
using Template.Job.Infrastructure.Home;

#endregion

namespace Template.Job.Api.HomeApi;

/// <summary>
/// </summary>
[ApiController]
[Route("Home")]
public class Index(IHomeApplication bll) : BaseApi<HomeArgs, PageResult<HomeResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Index")]
    public override async Task<PageResult<HomeResult>> InvokeAsync([FromBody] HomeArgs args)
    {
        return await bll.PageAsync(args);
    }
}