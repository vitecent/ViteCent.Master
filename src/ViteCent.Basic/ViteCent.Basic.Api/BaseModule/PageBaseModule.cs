#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Basic.Api.BaseModule;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseModule")]
[BaseLoginFilter]
public class PageBaseModule(IMediator mediator) : BaseLoginApi<SearchBaseModuleArgs, PageResult<BaseModuleResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Basic", "BaseModule", "Get")]
    public override async Task<PageResult<BaseModuleResult>> InvokeAsync(SearchBaseModuleArgs args)
    {
        if (args == null)
            return new PageResult<BaseModuleResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}