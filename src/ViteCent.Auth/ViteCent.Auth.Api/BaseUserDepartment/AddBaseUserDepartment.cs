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
public class AddBaseUserDepartment(IMediator mediator) : BaseLoginApi<AddBaseUserDepartmentArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    [BaseAuthFilter("Auth", "BaseUserDepartment", "Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseUserDepartmentArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");
        
        return await mediator.Send(args);
    }
}