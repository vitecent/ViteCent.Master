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
public class DeleteBaseDepartment(IMediator mediator) : BaseLoginApi<DeleteBaseDepartmentArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Delete")]
    [BaseAuthFilter("Auth", "BaseDepartment", "Delete")]
    public override async Task<BaseResult> InvokeAsync(DeleteBaseDepartmentArgs args)
    {
        if (args == null)
            return new BaseResult(500, "参数不能为空");

        return await mediator.Send(args);
    }
}