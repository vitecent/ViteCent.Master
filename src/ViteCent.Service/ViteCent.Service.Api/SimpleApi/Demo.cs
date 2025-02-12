﻿/*
 *
 * 版权所有 ：ViteCent
 * 作    者 ：ViteCent
 *
 */

#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Service.Infrastructure.Simple;

#endregion

namespace ViteCent.Service.Api.SimpleApi;

/// <summary>
///     Simple API 控制器
/// </summary>
[ApiController]
[Route("Simple")]
public class Demo(IMediator mediator) : BaseApi<SimpleArgs, PageResult<SimpleResult>>
{
    /// <summary>
    ///     处理首页请求
    /// </summary>
    /// <param name="args">请求参数</param>
    /// <returns>分页结果</returns>
    [HttpPost]
    [Route("Demo")]
    public override async Task<PageResult<SimpleResult>> InvokeAsync([FromBody] SimpleArgs args)
    {
        return await mediator.Send(args);
    }
}