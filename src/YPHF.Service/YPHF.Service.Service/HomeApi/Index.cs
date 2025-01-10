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
using YPHF.Service.Bll;
using YPHF.Service.Dto.Home;

#endregion

namespace YPHF.Service.Service.HomeApi;

/// <summary>
/// Home API 控制器
/// </summary>
[ApiController]
[Route("Home")]
public class Index(IHomeBll bll) : BaseApi<HomeArgs, PageResult<HomeResult>>
{
    /// <summary>
    /// 处理首页请求
    /// </summary>
    /// <param name="args">请求参数</param>
    /// <returns>分页结果</returns>
    [HttpPost]
    [Route("Index")]
    public override async Task<PageResult<HomeResult>> InvokeAsync([FromBody] HomeArgs args)
    {
        return await bll.PageAsync(args);
    }
}