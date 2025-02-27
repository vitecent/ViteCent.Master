#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseRolePermission;

/// <summary>
///     PageBaseRolePermission
/// </summary>
[ApiController]
[Route("BaseRolePermission")]
public class PageBaseRolePermission(IMediator mediator) : BaseApi<SearchBaseRolePermissionArgs, PageResult<BaseRolePermissionResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseRolePermissionResult>> InvokeAsync(SearchBaseRolePermissionArgs args)
    {
        return await mediator.Send(args);
    }
}