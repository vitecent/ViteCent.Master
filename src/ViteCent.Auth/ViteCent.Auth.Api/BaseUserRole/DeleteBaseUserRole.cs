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
public class DeleteBaseUserRole(IMediator mediator) : BaseLoginApi<DeleteBaseUserRoleArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Auth", "BaseUserRole", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseUserRoleArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}