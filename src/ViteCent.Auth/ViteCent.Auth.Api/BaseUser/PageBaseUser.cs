#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseUser;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUser")]
[BaseLoginFilter]
public class PageBaseUser(IMediator mediator) : BaseLoginApi<SearchBaseUserArgs, PageResult<BaseUserResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Auth", "BaseUser", "Get")]
    public override async Task<PageResult<BaseUserResult>> InvokeAsync(SearchBaseUserArgs args)
    {
        if (args == null)
            return new PageResult<BaseUserResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}