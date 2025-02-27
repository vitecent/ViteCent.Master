#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseUser;

/// <summary>
///     GetBaseUser
/// </summary>
[ApiController]
[Route("BaseUser")]
public class GetBaseUser(IMediator mediator) : BaseApi<GetBaseUserArgs, DataResult<BaseUserResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseUserResult>> InvokeAsync(GetBaseUserArgs args)
    {
        return await mediator.Send(args);
    }
}