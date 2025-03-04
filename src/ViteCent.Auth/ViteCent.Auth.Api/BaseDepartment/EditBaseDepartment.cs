using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

namespace ViteCent.Auth.Api.BaseDepartment;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseDepartment")]
[BaseLoginFilter]
public class EditBaseDepartment(IMediator mediator) : BaseLoginApi<EditBaseDepartmentArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Auth", "BaseDepartment", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseDepartmentArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}