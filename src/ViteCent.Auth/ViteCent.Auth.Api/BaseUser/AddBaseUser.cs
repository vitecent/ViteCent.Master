using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseUser;

/// <summary>
///     AddBaseUser
/// </summary>
[ApiController]
[Route("BaseUser")]
public class AddBaseUser(IMediator mediator) : BaseApi<AddBaseUserArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseUserArgs args)
    {
        return await mediator.Send(args);
    }
}