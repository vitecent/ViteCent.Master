#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseUserDepartment;

/// <summary>
///     GetBaseUserDepartment
/// </summary>
[ApiController]
[Route("BaseUserDepartment")]
public class GetBaseUserDepartment(IMediator mediator) : BaseApi<GetBaseUserDepartmentArgs, DataResult<BaseUserDepartmentResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseUserDepartmentResult>> InvokeAsync(GetBaseUserDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}