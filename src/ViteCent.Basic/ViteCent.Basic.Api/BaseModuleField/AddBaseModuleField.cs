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
public class AddBaseModuleField(IMediator mediator) : BaseLoginApi<AddBaseModuleFieldArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    [BaseAuthFilter("Basic", "BaseModuleField", "Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseModuleFieldArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}