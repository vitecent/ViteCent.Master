#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseUser;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUser")]
[BaseLoginFilter]
public class DeleteBaseUser(IMediator mediator) : BaseLoginApi<DeleteBaseUserArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Auth", "BaseUser", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseUserArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}