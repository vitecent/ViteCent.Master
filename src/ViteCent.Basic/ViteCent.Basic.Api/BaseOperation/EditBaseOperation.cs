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
public class EditBaseOperation(IMediator mediator) : BaseLoginApi<EditBaseOperationArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Basic", "BaseOperation", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseOperationArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}