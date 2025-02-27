using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseModuleField;

/// <summary>
///     AddBaseModuleField
/// </summary>
[ApiController]
[Route("BaseModuleField")]
public class AddBaseModuleField(IMediator mediator) : BaseApi<AddBaseModuleFieldArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseModuleFieldArgs args)
    {
        return await mediator.Send(args);
    }
}