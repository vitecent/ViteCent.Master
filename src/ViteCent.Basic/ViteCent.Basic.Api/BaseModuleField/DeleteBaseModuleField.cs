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
public class DeleteBaseModuleField(IMediator mediator) : BaseLoginApi<DeleteBaseModuleFieldArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Basic", "BaseModuleField", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseModuleFieldArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}