#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseModule;

/// <summary>
///     GetBaseModule
/// </summary>
[ApiController]
[Route("BaseModule")]
public class GetBaseModule(IMediator mediator) : BaseApi<GetBaseModuleArgs, DataResult<BaseModuleResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseModuleResult>> InvokeAsync(GetBaseModuleArgs args)
    {
        return await mediator.Send(args);
    }
}