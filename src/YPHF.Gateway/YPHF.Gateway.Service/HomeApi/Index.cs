﻿/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Mvc;
using YPHF.Core.Data;
using YPHF.Core.Web.Api;

namespace YPHF.Gateway.Service.HomeApi
{
    /// <summary>
    /// </summary>
    [ApiController]
    [Route("Home")]
    public class Index : BaseApi<BaseArgs, BaseResult>
    {
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Index")]
        public override async Task<BaseResult> InvokeAsync([FromBody] BaseArgs args)
            => await Task.FromResult(new BaseResult("Gateway Is Running At 7000"));
    }
}