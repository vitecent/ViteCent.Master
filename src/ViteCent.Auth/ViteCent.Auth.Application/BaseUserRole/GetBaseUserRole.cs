#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserRole;

/// <summary>
/// </summary>
public class GetBaseUserRole : IRequestHandler<GetBaseUserRoleArgs, DataResult<BaseUserRoleResult>>
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
    public GetBaseUserRole()
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
    public async Task<DataResult<BaseUserRoleResult>> Handle(GetBaseUserRoleArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseUserRoleEntityArgs>(request);
        args.CompanyId = user?.Company?.Id ?? string.Empty;

        var entity = await mediator.Send(args, cancellationToken);

        var dto = mapper.Map<BaseUserRoleResult>(entity);

        return new DataResult<BaseUserRoleResult>(dto);
    }
}