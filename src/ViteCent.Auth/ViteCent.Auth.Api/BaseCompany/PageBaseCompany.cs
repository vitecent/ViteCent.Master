#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseCompany;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseCompany")]
[BaseLoginFilter]
public class PageBaseCompany(IMediator mediator) : BaseLoginApi<SearchBaseCompanyArgs, PageResult<BaseCompanyResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Auth", "BaseCompany", "Get")]
    public override async Task<PageResult<BaseCompanyResult>> InvokeAsync(SearchBaseCompanyArgs args)
    {
        if (args == null)
            return new PageResult<BaseCompanyResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}