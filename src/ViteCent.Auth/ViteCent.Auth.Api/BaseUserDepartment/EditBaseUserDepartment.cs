using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseUserDepartment;

/// <summary>
///     BaseUserDepartment
/// </summary>
[ApiController]
[Route("BaseUserDepartment")]
public class EditBaseUserDepartment(IMediator mediator) : BaseApi<EditBaseUserDepartmentArgs, BaseResult>
{
    /// <summary>
    ///     Edit
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Edit")]
    public override async Task<BaseResult> InvokeAsync(EditBaseUserDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}