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
using Template.Service.Application;
using Template.Service.Infrastructure.Home;

#endregion

namespace Template.Service.Api.HomeApi;

/// <summary>
///     Home API 控制器
/// </summary>
[ApiController]
[Route("Home")]
public class Index(IHomeApplication Application) : BaseApi<HomeArgs, PageResult<HomeResult>>
{
    /// <summary>
    ///     处理首页请求
    /// </summary>
    /// <param name="args">请求参数</param>
    /// <returns>分页结果</returns>
    [HttpPost]
    [Route("Index")]
    public override async Task<PageResult<HomeResult>> InvokeAsync([FromBody] HomeArgs args)
    {
        return await Application.PageAsync(args);
    }
}