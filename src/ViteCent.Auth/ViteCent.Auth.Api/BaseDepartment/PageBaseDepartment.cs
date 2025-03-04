#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseDepartment;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseDepartment")]
[BaseLoginFilter]
public class PageBaseDepartment(IMediator mediator) : BaseLoginApi<SearchBaseDepartmentArgs, PageResult<BaseDepartmentResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Auth", "BaseDepartment", "Get")]
    public override async Task<PageResult<BaseDepartmentResult>> InvokeAsync(SearchBaseDepartmentArgs args)
    {
        if (args == null)
            return new PageResult<BaseDepartmentResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}