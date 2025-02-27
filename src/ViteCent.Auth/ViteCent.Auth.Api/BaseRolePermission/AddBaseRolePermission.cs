using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseRolePermission;

/// <summary>
///     AddBaseRolePermission
/// </summary>
[ApiController]
[Route("BaseRolePermission")]
public class AddBaseRolePermission(IMediator mediator) : BaseApi<AddBaseRolePermissionArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseRolePermissionArgs args)
    {
        return await mediator.Send(args);
    }
}