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
public class GetBaseRolePermission(IMediator mediator) : BaseLoginApi<GetBaseRolePermissionArgs, DataResult<BaseRolePermissionResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Auth", "BaseRolePermission", "Get")]
    public override async Task<DataResult<BaseRolePermissionResult>> InvokeAsync(GetBaseRolePermissionArgs args)
    {
        if (args == null)
            return new DataResult<BaseRolePermissionResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}