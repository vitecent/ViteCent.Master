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
public class DeleteBaseOperation(IMediator mediator) : BaseLoginApi<DeleteBaseOperationArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Basic", "BaseOperation", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseOperationArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}