#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Basic.Entity.BaseResource;
using ViteCent.Core;
using ViteCent.Core.Cache;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseResource;

/// <summary>
/// </summary>
public class AddBaseResource : IRequestHandler<AddBaseResourceArgs, BaseResult>
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
    public AddBaseResource()
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
    public async Task<BaseResult> Handle(AddBaseResourceArgs request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<AddBaseResourceEntity>(request);

        entity.Id = await cache.NextIdentity(new NextIdentifyArg()
        {
            CompanyId = user?.Company?.Id ?? string.Empty,
            Name = "BaseResource",
        });
        entity.CompanyId = user?.Company?.Id ?? string.Empty;
        entity.Creator = user?.Name ?? string.Empty;
        entity.CreateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity, cancellationToken);
    }
}