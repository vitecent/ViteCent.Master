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
public class EditBaseModuleField(IMediator mediator) : BaseLoginApi<EditBaseModuleFieldArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Basic", "BaseModuleField", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseModuleFieldArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}