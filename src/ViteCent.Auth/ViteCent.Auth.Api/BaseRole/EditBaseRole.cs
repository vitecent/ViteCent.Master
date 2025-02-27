using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseRole;

/// <summary>
///     BaseRole
/// </summary>
[ApiController]
[Route("BaseRole")]
public class EditBaseRole(IMediator mediator) : BaseApi<EditBaseRoleArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseRoleArgs args)
    {
        return await mediator.Send(args);
    }
}