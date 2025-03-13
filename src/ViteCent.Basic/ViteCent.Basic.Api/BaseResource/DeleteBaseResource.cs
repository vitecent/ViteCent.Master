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
public class DeleteBaseResource(IMediator mediator) : BaseLoginApi<DeleteBaseResourceArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Basic", "BaseResource", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseResourceArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}