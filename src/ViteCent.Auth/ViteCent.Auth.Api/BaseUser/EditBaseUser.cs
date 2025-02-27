using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseUser;

/// <summary>
///     BaseUser
/// </summary>
[ApiController]
[Route("BaseUser")]
public class EditBaseUser(IMediator mediator) : BaseApi<EditBaseUserArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseUserArgs args)
    {
        return await mediator.Send(args);
    }
}