#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Auth.Entity.BaseRole;
using ViteCent.Core;
using ViteCent.Core.Cache;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRole;

/// <summary>
/// </summary>
public class AddBaseRole : IRequestHandler<AddBaseRoleArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    private readonly IBaseCache cache;

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
    public AddBaseRole()
    {
        var context = BaseHttpContext.Context;

        cache = context.RequestServices.GetService(typeof(IBaseCache)) as IBaseCache ?? default!;
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
    public async Task<BaseResult> Handle(AddBaseRoleArgs request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<AddBaseRoleEntity>(request);

        entity.Id = await cache.NextIdentity(new NextIdentifyArg()
        {
            CompanyId = user?.Company?.Id ?? string.Empty,
            Name = "BaseRole",
        });
        entity.CompanyId = user?.Company?.Id ?? string.Empty;
        entity.Creator = user?.Name ?? string.Empty;
        entity.CreateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity, cancellationToken);
    }
}