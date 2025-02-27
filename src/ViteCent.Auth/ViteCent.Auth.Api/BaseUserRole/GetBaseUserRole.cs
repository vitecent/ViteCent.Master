#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseUserRole;

/// <summary>
///     GetBaseUserRole
/// </summary>
[ApiController]
[Route("BaseUserRole")]
public class GetBaseUserRole(IMediator mediator) : BaseApi<GetBaseUserRoleArgs, DataResult<BaseUserRoleResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseUserRoleResult>> InvokeAsync(GetBaseUserRoleArgs args)
    {
        return await mediator.Send(args);
    }
}