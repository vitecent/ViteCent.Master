#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseRole;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseRole")]
[BaseLoginFilter]
public class PageBaseRole(IMediator mediator) : BaseLoginApi<SearchBaseRoleArgs, PageResult<BaseRoleResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Auth", "BaseRole", "Get")]
    public override async Task<PageResult<BaseRoleResult>> InvokeAsync(SearchBaseRoleArgs args)
    {
        if (args == null)
            return new PageResult<BaseRoleResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}