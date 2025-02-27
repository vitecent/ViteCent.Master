#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseDepartment;

/// <summary>
///     PageBaseDepartment
/// </summary>
[ApiController]
[Route("BaseDepartment")]
public class PageBaseDepartment(IMediator mediator) : BaseApi<SearchBaseDepartmentArgs, PageResult<BaseDepartmentResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseDepartmentResult>> InvokeAsync(SearchBaseDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}