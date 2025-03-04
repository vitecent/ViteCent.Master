using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

namespace ViteCent.Auth.Api.BaseRole;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseRole")]
[BaseLoginFilter]
public class AddBaseRole(IMediator mediator) : BaseLoginApi<AddBaseRoleArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    [BaseAuthFilter("Auth", "BaseRole", "Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseRoleArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");
        
        return await mediator.Send(args);
    }
}