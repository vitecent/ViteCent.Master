using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseCompany;

/// <summary>
///     BaseCompany
/// </summary>
[ApiController]
[Route("BaseCompany")]
public class EditBaseCompany(IMediator mediator) : BaseApi<EditBaseCompanyArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseCompanyArgs args)
    {
        return await mediator.Send(args);
    }
}