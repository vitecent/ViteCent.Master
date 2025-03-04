using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

namespace ViteCent.Auth.Api.BaseUser;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUser")]
[BaseLoginFilter]
public class EditBaseUser(IMediator mediator) : BaseLoginApi<EditBaseUserArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Auth", "BaseUser", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseUserArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}