#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseModuleField;

/// <summary>
///     GetBaseModuleField
/// </summary>
[ApiController]
[Route("BaseModuleField")]
public class GetBaseModuleField(IMediator mediator) : BaseApi<GetBaseModuleFieldArgs, DataResult<BaseModuleFieldResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseModuleFieldResult>> InvokeAsync(GetBaseModuleFieldArgs args)
    {
        return await mediator.Send(args);
    }
}