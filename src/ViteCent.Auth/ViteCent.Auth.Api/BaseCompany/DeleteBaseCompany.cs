#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseCompany;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseCompany")]
[BaseLoginFilter]
public class DeleteBaseCompany(IMediator mediator) : BaseLoginApi<DeleteBaseCompanyArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Auth", "BaseCompany", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseCompanyArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}