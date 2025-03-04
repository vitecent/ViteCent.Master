#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Basic.Api.BaseModule;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseModule")]
[BaseLoginFilter]
public class GetBaseModule(IMediator mediator) : BaseLoginApi<GetBaseModuleArgs, DataResult<BaseModuleResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Basic", "BaseModule", "Get")]
    public override async Task<DataResult<BaseModuleResult>> InvokeAsync(GetBaseModuleArgs args)
    {
        if (args == null)
            return new DataResult<BaseModuleResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}