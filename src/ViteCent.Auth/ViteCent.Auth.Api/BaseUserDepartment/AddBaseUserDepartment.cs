using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseUserDepartment;

/// <summary>
///     AddBaseUserDepartment
/// </summary>
[ApiController]
[Route("BaseUserDepartment")]
public class AddBaseUserDepartment(IMediator mediator) : BaseApi<AddBaseUserDepartmentArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseUserDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}