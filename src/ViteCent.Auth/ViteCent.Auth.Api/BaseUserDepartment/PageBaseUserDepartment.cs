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
public class PageBaseUserDepartment(IMediator mediator) : BaseLoginApi<SearchBaseUserDepartmentArgs, PageResult<BaseUserDepartmentResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Auth", "BaseUserDepartment", "Get")]
    public override async Task<PageResult<BaseUserDepartmentResult>> InvokeAsync(SearchBaseUserDepartmentArgs args)
    {
        if (args == null)
            return new PageResult<BaseUserDepartmentResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}