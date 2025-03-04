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
public class PageBaseRolePermission(IMediator mediator) : BaseLoginApi<SearchBaseRolePermissionArgs, PageResult<BaseRolePermissionResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Auth", "BaseRolePermission", "Get")]
    public override async Task<PageResult<BaseRolePermissionResult>> InvokeAsync(SearchBaseRolePermissionArgs args)
    {
        if (args == null)
            return new PageResult<BaseRolePermissionResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}