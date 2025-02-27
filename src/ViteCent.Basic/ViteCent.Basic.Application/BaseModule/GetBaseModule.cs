#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModule;

/// <summary>
///     GetBaseModule
/// </summary>
public class GetBaseModule : IRequestHandler<GetBaseModuleArgs, DataResult<BaseModuleResult>>
{
    /// <summary>
    ///     _mediator
    /// </summary>
    private readonly IMapper _mapper;

    /// <summary>
    ///     _mediator
    /// </summary>
    private readonly IMediator _mediator;

    /// <summary>
    ///     GetBaseModule
    /// </summary>
    public GetBaseModule()
    {
        var context = BaseHttpContext.Context;

        _mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;
        _mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
    }

    /// <summary>
    ///     Handle
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<DataResult<BaseModuleResult>> Handle(GetBaseModuleArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseModuleEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseModuleResult>(entity);

        return new DataResult<BaseModuleResult>(dto);
        ;
    }
}