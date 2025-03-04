#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Core.Web.Filter;

#endregion

namespace ViteCent.Auth.Api.BaseDepartment;

/// <summary>
/// </summary>
[ApiController]
[Route("BaseDepartment")]
[BaseLoginFilter]
public class GetBaseDepartment(IMediator mediator) : BaseLoginApi<GetBaseDepartmentArgs, DataResult<BaseDepartmentResult>>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    [BaseAuthFilter("Auth", "BaseDepartment", "Get")]
    public override async Task<DataResult<BaseDepartmentResult>> InvokeAsync(GetBaseDepartmentArgs args)
    {
        if (args == null)
            return new DataResult<BaseDepartmentResult>(500, "参数不能为空");

        return await mediator.Send(args);
    }
}