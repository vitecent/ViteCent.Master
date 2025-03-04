#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseUserRole;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUserRole")]
[BaseLoginFilter]
public class PageBaseUserRole(IMediator mediator) : BaseLoginApi<SearchBaseUserRoleArgs, PageResult<BaseUserRoleResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Auth", "BaseUserRole", "Get")]
    public override async Task<PageResult<BaseUserRoleResult>> InvokeAsync(SearchBaseUserRoleArgs args)
    {
        if (args == null)
            return new PageResult<BaseUserRoleResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}