#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseRolePermission;

/// <summary>
///     GetBaseRolePermission
/// </summary>
[ApiController]
[Route("BaseRolePermission")]
public class GetBaseRolePermission(IMediator mediator) : BaseApi<GetBaseRolePermissionArgs, DataResult<BaseRolePermissionResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseRolePermissionResult>> InvokeAsync(GetBaseRolePermissionArgs args)
    {
        return await mediator.Send(args);
    }
}