#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModule;
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
    public GetBaseModule()
    {
        var context = BaseHttpContext.Context;

        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;
        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<DataResult<BaseModuleResult>> Handle(GetBaseModuleArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseModuleEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseModuleResult>(entity);

        return new DataResult<BaseModuleResult>(dto);
        ;
    }
}