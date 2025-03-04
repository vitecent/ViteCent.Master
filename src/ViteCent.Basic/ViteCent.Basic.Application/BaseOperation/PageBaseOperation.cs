#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseOperation;

/// <summary>
/// </summary>
public class PageBaseOperation : IRequestHandler<SearchBaseOperationArgs, PageResult<BaseOperationResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseOperation()
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
    public async Task<PageResult<BaseOperationResult>> Handle(SearchBaseOperationArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseOperationEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseOperationResult>>(list);

        var result = new PageResult<BaseOperationResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}