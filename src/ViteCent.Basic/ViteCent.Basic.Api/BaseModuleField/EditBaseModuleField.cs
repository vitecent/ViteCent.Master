using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseModuleField;

/// <summary>
///     BaseModuleField
/// </summary>
[ApiController]
[Route("BaseModuleField")]
public class EditBaseModuleField(IMediator mediator) : BaseApi<EditBaseModuleFieldArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseModuleFieldArgs args)
    {
        return await mediator.Send(args);
    }
}