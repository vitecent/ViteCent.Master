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
public class GetBaseUser(IMediator mediator) : BaseLoginApi<GetBaseUserArgs, DataResult<BaseUserResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Auth", "BaseUser", "Get")]
    public override async Task<DataResult<BaseUserResult>> InvokeAsync(GetBaseUserArgs args)
    {
        if (args == null)
            return new DataResult<BaseUserResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}