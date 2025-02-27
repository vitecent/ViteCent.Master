using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseOperation;

/// <summary>
///     AddBaseOperation
/// </summary>
[ApiController]
[Route("BaseOperation")]
public class AddBaseOperation(IMediator mediator) : BaseApi<AddBaseOperationArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseOperationArgs args)
    {
        return await mediator.Send(args);
    }
}