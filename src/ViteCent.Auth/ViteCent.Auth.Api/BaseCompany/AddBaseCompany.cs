using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

namespace ViteCent.Auth.Api.BaseCompany;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseCompany")]
[BaseLoginFilter]
public class AddBaseCompany(IMediator mediator) : BaseLoginApi<AddBaseCompanyArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    [BaseAuthFilter("Auth", "BaseCompany", "Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseCompanyArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");
        
        return await mediator.Send(args);
    }
}