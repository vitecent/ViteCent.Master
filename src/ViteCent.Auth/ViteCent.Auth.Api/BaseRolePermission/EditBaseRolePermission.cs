using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseRolePermission;

/// <summary>
///     BaseRolePermission
/// </summary>
[ApiController]
[Route("BaseRolePermission")]
public class EditBaseRolePermission(IMediator mediator) : BaseApi<EditBaseRolePermissionArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseRolePermissionArgs args)
    {
        return await mediator.Send(args);
    }
}