using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseModule;

/// <summary>
///     BaseModule
/// </summary>
[ApiController]
[Route("BaseModule")]
public class EditBaseModule(IMediator mediator) : BaseApi<EditBaseModuleArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseModuleArgs args)
    {
        return await mediator.Send(args);
    }
}