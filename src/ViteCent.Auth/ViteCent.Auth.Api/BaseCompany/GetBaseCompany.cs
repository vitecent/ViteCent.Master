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
public class GetBaseCompany(IMediator mediator) : BaseLoginApi<GetBaseCompanyArgs, DataResult<BaseCompanyResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Auth", "BaseCompany", "Get")]
    public override async Task<DataResult<BaseCompanyResult>> InvokeAsync(GetBaseCompanyArgs args)
    {
        if (args == null)
            return new DataResult<BaseCompanyResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}