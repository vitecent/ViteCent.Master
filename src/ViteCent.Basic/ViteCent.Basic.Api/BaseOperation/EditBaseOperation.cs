using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseOperation;

/// <summary>
///     BaseOperation
/// </summary>
[ApiController]
[Route("BaseOperation")]
public class EditBaseOperation(IMediator mediator) : BaseApi<EditBaseOperationArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseOperationArgs args)
    {
        return await mediator.Send(args);
    }
}