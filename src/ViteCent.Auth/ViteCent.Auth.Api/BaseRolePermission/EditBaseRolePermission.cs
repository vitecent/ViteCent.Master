#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseRolePermission;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseRolePermission")]
[BaseLoginFilter]
public class EditBaseRolePermission(IMediator mediator) : BaseLoginApi<EditBaseRolePermissionArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Auth", "BaseRolePermission", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseRolePermissionArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}