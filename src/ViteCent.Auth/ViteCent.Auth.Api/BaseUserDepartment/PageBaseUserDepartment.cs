#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseUserDepartment;

/// <summary>
///     PageBaseUserDepartment
/// </summary>
[ApiController]
[Route("BaseUserDepartment")]
public class PageBaseUserDepartment(IMediator mediator) : BaseApi<SearchBaseUserDepartmentArgs, PageResult<BaseUserDepartmentResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseUserDepartmentResult>> InvokeAsync(SearchBaseUserDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}