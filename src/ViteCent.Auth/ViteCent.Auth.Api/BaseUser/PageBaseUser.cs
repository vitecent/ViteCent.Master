#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseUser;

/// <summary>
///     PageBaseUser
/// </summary>
[ApiController]
[Route("BaseUser")]
public class PageBaseUser(IMediator mediator) : BaseApi<SearchBaseUserArgs, PageResult<BaseUserResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseUserResult>> InvokeAsync(SearchBaseUserArgs args)
    {
        return await mediator.Send(args);
    }
}