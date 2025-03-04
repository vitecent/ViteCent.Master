#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Basic.Entity;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModuleField;

/// <summary>
/// </summary>
public class AddBaseModuleField : IRequestHandler<AddBaseModuleFieldArgs, BaseResult>
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
    public AddBaseModuleField()
    {
        var context = BaseHttpContext.Context;

        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;
        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;

        var json = context.User.FindFirstValue(ClaimTypes.UserData);

        if (!string.IsNullOrWhiteSpace(json))
            user = json.DeJson<BaseUserInfo>();
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(AddBaseModuleFieldArgs request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<AddBaseModuleFieldEntity>(request);

        entity.Id = Guid.NewGuid().ToString("N");
        entity.Creator = user?.Name ?? string.Empty;;
        entity.CreateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity);
    }
}