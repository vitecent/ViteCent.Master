using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseUserRole;

/// <summary>
///     AddBaseUserRole
/// </summary>
[ApiController]
[Route("BaseUserRole")]
public class AddBaseUserRole(IMediator mediator) : BaseApi<AddBaseUserRoleArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseUserRoleArgs args)
    {
        return await mediator.Send(args);
    }
}