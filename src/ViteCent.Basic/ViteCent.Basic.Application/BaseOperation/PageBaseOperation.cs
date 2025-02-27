#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseOperation;

/// <summary>
///     PageBaseOperation
/// </summary>
public class PageBaseOperation : IRequestHandler<SearchBaseOperationArgs, PageResult<BaseOperationResult>>
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
    ///     PageBaseOperation
    /// </summary>
    public PageBaseOperation()
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
    public async Task<PageResult<BaseOperationResult>> Handle(SearchBaseOperationArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseOperationEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseOperationResult>>(list);

        var result = new PageResult<BaseOperationResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}