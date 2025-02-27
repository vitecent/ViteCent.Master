#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseRole;

/// <summary>
///     PageBaseRole
/// </summary>
[ApiController]
[Route("BaseRole")]
public class PageBaseRole(IMediator mediator) : BaseApi<SearchBaseRoleArgs, PageResult<BaseRoleResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseRoleResult>> InvokeAsync(SearchBaseRoleArgs args)
    {
        return await mediator.Send(args);
    }
}