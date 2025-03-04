#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseRole;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseRole")]
[BaseLoginFilter]
public class GetBaseRole(IMediator mediator) : BaseLoginApi<GetBaseRoleArgs, DataResult<BaseRoleResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Auth", "BaseRole", "Get")]
    public override async Task<DataResult<BaseRoleResult>> InvokeAsync(GetBaseRoleArgs args)
    {
        if (args == null)
            return new DataResult<BaseRoleResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}