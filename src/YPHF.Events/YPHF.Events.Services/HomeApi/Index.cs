/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Mvc;
using YPHF.Core.Data;
using YPHF.Core.Web.Api;
using YPHF.Events.Bll;
using YPHF.Events.Dto.Home;

namespace YPHF.Events.Services.HomeApi
{
    /// <summary>
    /// </summary>
    [ApiController]
    [Route("Home")]
    public class Index(IHomeBll bll) : BaseApi<HomeArgs, PageResult<HomeResult>>
    {
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Index")]
        public override async Task<PageResult<HomeResult>> InvokeAsync([FromBody] HomeArgs args)
            => await bll.PageAsync(args);
    }
}