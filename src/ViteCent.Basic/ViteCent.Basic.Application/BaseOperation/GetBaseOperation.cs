#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseOperation;

/// <summary>
///     GetBaseOperation
/// </summary>
public class GetBaseOperation : IRequestHandler<GetBaseOperationArgs, DataResult<BaseOperationResult>>
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
    ///     GetBaseOperation
    /// </summary>
    public GetBaseOperation()
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
    public async Task<DataResult<BaseOperationResult>> Handle(GetBaseOperationArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseOperationEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseOperationResult>(entity);

        return new DataResult<BaseOperationResult>(dto);
        ;
    }
}