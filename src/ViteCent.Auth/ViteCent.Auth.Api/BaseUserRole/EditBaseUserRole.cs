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
public class EditBaseUserRole(IMediator mediator) : BaseLoginApi<EditBaseUserRoleArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Auth", "BaseUserRole", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseUserRoleArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}