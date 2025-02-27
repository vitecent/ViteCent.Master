#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseCompany;

/// <summary>
///     PageBaseCompany
/// </summary>
[ApiController]
[Route("BaseCompany")]
public class PageBaseCompany(IMediator mediator) : BaseApi<SearchBaseCompanyArgs, PageResult<BaseCompanyResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseCompanyResult>> InvokeAsync(SearchBaseCompanyArgs args)
    {
        return await mediator.Send(args);
    }
}