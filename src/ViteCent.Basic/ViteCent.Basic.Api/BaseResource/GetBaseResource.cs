#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Basic.Api.BaseResource;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseResource")]
[BaseLoginFilter]
public class GetBaseResource(IMediator mediator) : BaseLoginApi<GetBaseResourceArgs, DataResult<BaseResourceResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Basic", "BaseResource", "Get")]
    public override async Task<DataResult<BaseResourceResult>> InvokeAsync(GetBaseResourceArgs args)
    {
        if (args == null)
            return new DataResult<BaseResourceResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}