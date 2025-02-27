#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseResource;

/// <summary>
///     PageBaseResource
/// </summary>
[ApiController]
[Route("BaseResource")]
public class PageBaseResource(IMediator mediator) : BaseApi<SearchBaseResourceArgs, PageResult<BaseResourceResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseResourceResult>> InvokeAsync(SearchBaseResourceArgs args)
    {
        return await mediator.Send(args);
    }
}