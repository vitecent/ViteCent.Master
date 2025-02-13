/*
 *
 * 作    者 ：vitecent
 * 作    者 ：ViteCent
 *
 */

#region

using Microsoft.AspNetCore.Mvc;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Gateway.Api.SimpleApi;

/// <summary>
/// </summary>
[ApiController]
[Route("Simple")]
public class Demo : BaseApi<BaseArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Demo")]
    public override async Task<BaseResult> InvokeAsync([FromBody] BaseArgs args)
    {
        return await Task.FromResult(new BaseResult("Gateway Is Running"));
    }
}