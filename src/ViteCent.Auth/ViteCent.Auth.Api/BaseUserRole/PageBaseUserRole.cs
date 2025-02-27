#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseUserRole;

/// <summary>
///     PageBaseUserRole
/// </summary>
[ApiController]
[Route("BaseUserRole")]
public class PageBaseUserRole(IMediator mediator) : BaseApi<SearchBaseUserRoleArgs, PageResult<BaseUserRoleResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseUserRoleResult>> InvokeAsync(SearchBaseUserRoleArgs args)
    {
        return await mediator.Send(args);
    }
}