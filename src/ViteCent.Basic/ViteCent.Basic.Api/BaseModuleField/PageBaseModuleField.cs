#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Basic.Api.BaseModuleField;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseModuleField")]
[BaseLoginFilter]
public class PageBaseModuleField(IMediator mediator) : BaseLoginApi<SearchBaseModuleFieldArgs, PageResult<BaseModuleFieldResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Page")]
    [BaseAuthFilter("Basic", "BaseModuleField", "Get")]
    public override async Task<PageResult<BaseModuleFieldResult>> InvokeAsync(SearchBaseModuleFieldArgs args)
    {
        if (args == null)
            return new PageResult<BaseModuleFieldResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}