#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Basic.Api.BaseResource;

/// <summary>
///     GetBaseResource
/// </summary>
[ApiController]
[Route("BaseResource")]
public class GetBaseResource(IMediator mediator) : BaseApi<GetBaseResourceArgs, DataResult<BaseResourceResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseResourceResult>> InvokeAsync(GetBaseResourceArgs args)
    {
        return await mediator.Send(args);
    }
}