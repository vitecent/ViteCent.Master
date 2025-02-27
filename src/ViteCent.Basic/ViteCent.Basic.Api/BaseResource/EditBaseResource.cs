using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseResource;

/// <summary>
///     BaseResource
/// </summary>
[ApiController]
[Route("BaseResource")]
public class EditBaseResource(IMediator mediator) : BaseApi<EditBaseResourceArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseResourceArgs args)
    {
        return await mediator.Send(args);
    }
}