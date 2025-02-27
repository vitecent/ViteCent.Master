#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseModule;

/// <summary>
///     PageBaseModule
/// </summary>
[ApiController]
[Route("BaseModule")]
public class PageBaseModule(IMediator mediator) : BaseApi<SearchBaseModuleArgs, PageResult<BaseModuleResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseModuleResult>> InvokeAsync(SearchBaseModuleArgs args)
    {
        return await mediator.Send(args);
    }
}