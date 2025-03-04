#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseUserRole;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUserRole")]
[BaseLoginFilter]
public class GetBaseUserRole(IMediator mediator) : BaseLoginApi<GetBaseUserRoleArgs, DataResult<BaseUserRoleResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Auth", "BaseUserRole", "Get")]
    public override async Task<DataResult<BaseUserRoleResult>> InvokeAsync(GetBaseUserRoleArgs args)
    {
        if (args == null)
            return new DataResult<BaseUserRoleResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}