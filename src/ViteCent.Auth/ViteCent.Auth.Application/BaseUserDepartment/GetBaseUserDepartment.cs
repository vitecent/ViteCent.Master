#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserDepartment;

/// <summary>
/// </summary>
public class GetBaseUserDepartment : IRequestHandler<GetBaseUserDepartmentArgs, DataResult<BaseUserDepartmentResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    private readonly BaseUserInfo user;

    /// <summary>
    /// </summary>
    public GetBaseUserDepartment()
    {
        var context = BaseHttpContext.Context;

        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;

        var json = context.User.FindFirstValue(ClaimTypes.UserData);

        if (!string.IsNullOrWhiteSpace(json))
            user = json.DeJson<BaseUserInfo>();
        else
            user = new BaseUserInfo();
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<DataResult<BaseUserDepartmentResult>> Handle(GetBaseUserDepartmentArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseUserDepartmentEntityArgs>(request);
        args.CompanyId = user?.Company?.Id ?? string.Empty;

        var entity = await mediator.Send(args, cancellationToken);

        var dto = mapper.Map<BaseUserDepartmentResult>(entity);

        return new DataResult<BaseUserDepartmentResult>(dto);
    }
}