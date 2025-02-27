using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseRole;

/// <summary>
///     AddBaseRole
/// </summary>
[ApiController]
[Route("BaseRole")]
public class AddBaseRole(IMediator mediator) : BaseApi<AddBaseRoleArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseRoleArgs args)
    {
        return await mediator.Send(args);
    }
}