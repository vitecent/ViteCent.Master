#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModuleField;

/// <summary>
///     GetBaseModuleField
/// </summary>
public class GetBaseModuleField : IRequestHandler<GetBaseModuleFieldArgs, DataResult<BaseModuleFieldResult>>
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
    ///     GetBaseModuleField
    /// </summary>
    public GetBaseModuleField()
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
    public async Task<DataResult<BaseModuleFieldResult>> Handle(GetBaseModuleFieldArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseModuleFieldEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseModuleFieldResult>(entity);

        return new DataResult<BaseModuleFieldResult>(dto);
        ;
    }
}