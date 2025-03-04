using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

namespace ViteCent.Auth.Api.BaseUserDepartment;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUserDepartment")]
[BaseLoginFilter]
public class EditBaseUserDepartment(IMediator mediator) : BaseLoginApi<EditBaseUserDepartmentArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Auth", "BaseUserDepartment", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseUserDepartmentArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}