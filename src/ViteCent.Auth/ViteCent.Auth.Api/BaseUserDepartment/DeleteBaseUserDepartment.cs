#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseUserDepartment;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUserDepartment")]
[BaseLoginFilter]
public class DeleteBaseUserDepartment(IMediator mediator) : BaseLoginApi<DeleteBaseUserDepartmentArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Auth", "BaseUserDepartment", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseUserDepartmentArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}