#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Basic.Api.BaseOperation;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseOperation")]
[BaseLoginFilter]
public class PageBaseOperation(IMediator mediator) : BaseLoginApi<SearchBaseOperationArgs, PageResult<BaseOperationResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Basic", "BaseOperation", "Get")]
    public override async Task<PageResult<BaseOperationResult>> InvokeAsync(SearchBaseOperationArgs args)
    {
        if (args == null)
            return new PageResult<BaseOperationResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}