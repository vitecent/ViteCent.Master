using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Basic.Api.BaseResource;

/// <summary>
///     AddBaseResource
/// </summary>
[ApiController]
[Route("BaseResource")]
public class AddBaseResource(IMediator mediator) : BaseApi<AddBaseResourceArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseResourceArgs args)
    {
        return await mediator.Send(args);
    }
}