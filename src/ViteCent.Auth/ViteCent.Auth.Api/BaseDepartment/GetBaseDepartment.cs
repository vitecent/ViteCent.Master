#region

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

#endregion

namespace ViteCent.Auth.Api.BaseDepartment;

/// <summary>
///     GetBaseDepartment
/// </summary>
[ApiController]
[Route("BaseDepartment")]
public class GetBaseDepartment(IMediator mediator) : BaseApi<GetBaseDepartmentArgs, DataResult<BaseDepartmentResult>>
{
    /// <summary>
    ///     Get
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Get")]
    public override async Task<DataResult<BaseDepartmentResult>> InvokeAsync(GetBaseDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}