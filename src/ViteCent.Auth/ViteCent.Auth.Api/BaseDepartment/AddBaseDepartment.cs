using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;

namespace ViteCent.Auth.Api.BaseDepartment;

/// <summary>
///     AddBaseDepartment
/// </summary>
[ApiController]
[Route("BaseDepartment")]
public class AddBaseDepartment(IMediator mediator) : BaseApi<AddBaseDepartmentArgs, BaseResult>
{
    /// <summary>
    ///     Add
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Add")]
    public override async Task<BaseResult> InvokeAsync(AddBaseDepartmentArgs args)
    {
        return await mediator.Send(args);
    }
}