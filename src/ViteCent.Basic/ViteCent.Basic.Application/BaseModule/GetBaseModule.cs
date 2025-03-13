#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModule;

/// <summary>
/// </summary>
public class GetBaseModule : IRequestHandler<GetBaseModuleArgs, DataResult<BaseModuleResult>>
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
    public GetBaseModule()
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
    public async Task<DataResult<BaseModuleResult>> Handle(GetBaseModuleArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseModuleEntityArgs>(request);
        args.CompanyId = user?.Company?.Id ?? string.Empty;

        var entity = await mediator.Send(args, cancellationToken);

        var dto = mapper.Map<BaseModuleResult>(entity);

        return new DataResult<BaseModuleResult>(dto);
    }
}