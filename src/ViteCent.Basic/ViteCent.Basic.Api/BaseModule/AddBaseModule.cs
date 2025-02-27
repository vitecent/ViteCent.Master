using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseModule;

/// <summary>
///     AddBaseModule
/// </summary>
[ApiController]
[Route("BaseModule")]
public class AddBaseModule(IMediator mediator) : BaseApi<AddBaseModuleArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseModuleArgs args)
    {
        return await mediator.Send(args);
    }
}