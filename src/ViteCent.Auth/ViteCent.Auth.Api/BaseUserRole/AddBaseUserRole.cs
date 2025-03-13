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
public class AddBaseUserRole(IMediator mediator) : BaseLoginApi<AddBaseUserRoleArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    [BaseAuthFilter("Auth", "BaseUserRole", "Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseUserRoleArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}