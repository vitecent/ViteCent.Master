#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseUserDepartment;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseUserDepartment")]
[BaseLoginFilter]
public class GetBaseUserDepartment(IMediator mediator) : BaseLoginApi<GetBaseUserDepartmentArgs, DataResult<BaseUserDepartmentResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Auth", "BaseUserDepartment", "Get")]
    public override async Task<DataResult<BaseUserDepartmentResult>> InvokeAsync(GetBaseUserDepartmentArgs args)
    {
        if (args == null)
            return new DataResult<BaseUserDepartmentResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}