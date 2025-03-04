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
public class GetBaseOperation(IMediator mediator) : BaseLoginApi<GetBaseOperationArgs, DataResult<BaseOperationResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Basic", "BaseOperation", "Get")]
    public override async Task<DataResult<BaseOperationResult>> InvokeAsync(GetBaseOperationArgs args)
    {
        if (args == null)
            return new DataResult<BaseOperationResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}