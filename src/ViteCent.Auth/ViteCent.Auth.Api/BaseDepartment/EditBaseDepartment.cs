using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseDepartment;

/// <summary>
///     BaseDepartment
/// </summary>
[ApiController]
[Route("BaseDepartment")]
public class EditBaseDepartment(IMediator mediator) : BaseApi<EditBaseDepartmentArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}