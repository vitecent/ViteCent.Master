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
public class AddBaseResource(IMediator mediator) : BaseLoginApi<AddBaseResourceArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    [BaseAuthFilter("Basic", "BaseResource", "Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseResourceArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}