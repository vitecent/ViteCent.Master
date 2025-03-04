using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

namespace ViteCent.Basic.Api.BaseResource;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseResource")]
[BaseLoginFilter]
public class EditBaseResource(IMediator mediator) : BaseLoginApi<EditBaseResourceArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    [BaseAuthFilter("Basic", "BaseResource", "Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseResourceArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}