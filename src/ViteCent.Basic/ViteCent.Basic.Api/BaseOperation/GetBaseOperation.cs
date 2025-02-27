#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseOperation;

/// <summary>
///     GetBaseOperation
/// </summary>
[ApiController]
[Route("BaseOperation")]
public class GetBaseOperation(IMediator mediator) : BaseApi<GetBaseOperationArgs, DataResult<BaseOperationResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseOperationResult>> InvokeAsync(GetBaseOperationArgs args)
    {
        return await mediator.Send(args);
    }
}