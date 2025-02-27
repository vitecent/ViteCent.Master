#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseRole;

/// <summary>
///     GetBaseRole
/// </summary>
[ApiController]
[Route("BaseRole")]
public class GetBaseRole(IMediator mediator) : BaseApi<GetBaseRoleArgs, DataResult<BaseRoleResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseRoleResult>> InvokeAsync(GetBaseRoleArgs args)
    {
        return await mediator.Send(args);
    }
}