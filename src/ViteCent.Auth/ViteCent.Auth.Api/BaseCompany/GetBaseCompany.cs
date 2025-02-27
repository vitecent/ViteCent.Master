#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseCompany;

/// <summary>
///     GetBaseCompany
/// </summary>
[ApiController]
[Route("BaseCompany")]
public class GetBaseCompany(IMediator mediator) : BaseApi<GetBaseCompanyArgs, DataResult<BaseCompanyResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseCompanyResult>> InvokeAsync(GetBaseCompanyArgs args)
    {
        return await mediator.Send(args);
    }
}