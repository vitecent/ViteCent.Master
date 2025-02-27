#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseOperation;

/// <summary>
///     PageBaseOperation
/// </summary>
[ApiController]
[Route("BaseOperation")]
public class PageBaseOperation(IMediator mediator) : BaseApi<SearchBaseOperationArgs, PageResult<BaseOperationResult>>
{
    /// <summary>
    ///     Page
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    public override async Task<PageResult<BaseOperationResult>> InvokeAsync(SearchBaseOperationArgs args)
    {
        return await mediator.Send(args);
    }
}