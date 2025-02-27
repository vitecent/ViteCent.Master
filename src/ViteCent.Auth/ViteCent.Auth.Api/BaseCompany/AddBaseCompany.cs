using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseCompany;

/// <summary>
///     AddBaseCompany
/// </summary>
[ApiController]
[Route("BaseCompany")]
public class AddBaseCompany(IMediator mediator) : BaseApi<AddBaseCompanyArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseCompanyArgs args)
    {
        return await mediator.Send(args);
    }
}