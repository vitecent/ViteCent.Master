using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseUserRole;

/// <summary>
///     BaseUserRole
/// </summary>
[ApiController]
[Route("BaseUserRole")]
public class EditBaseUserRole(IMediator mediator) : BaseApi<EditBaseUserRoleArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseUserRoleArgs args)
    {
        return await mediator.Send(args);
    }
}