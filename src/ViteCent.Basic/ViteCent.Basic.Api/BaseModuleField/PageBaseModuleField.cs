#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseModuleField;

/// <summary>
///     PageBaseModuleField
/// </summary>
[ApiController]
[Route("BaseModuleField")]
public class PageBaseModuleField(IMediator mediator) : BaseApi<SearchBaseModuleFieldArgs, PageResult<BaseModuleFieldResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseModuleFieldResult>> InvokeAsync(SearchBaseModuleFieldArgs args)
    {
        return await mediator.Send(args);
    }
}