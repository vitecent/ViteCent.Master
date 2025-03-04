using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

namespace ViteCent.Basic.Api.BaseModule;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseModule")]
[BaseLoginFilter]
public class AddBaseModule(IMediator mediator) : BaseLoginApi<AddBaseModuleArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    [BaseAuthFilter("Basic", "BaseModule", "Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseModuleArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");
        
        return await mediator.Send(args);
    }
}