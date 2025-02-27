#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseResource;

/// <summary>
///     PageBaseResource
/// </summary>
public class PageBaseResource : IRequestHandler<SearchBaseResourceArgs, PageResult<BaseResourceResult>>
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
    ///     PageBaseResource
    /// </summary>
    public PageBaseResource()
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
    public async Task<PageResult<BaseResourceResult>> Handle(SearchBaseResourceArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseResourceEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseResourceResult>>(list);

        var result = new PageResult<BaseResourceResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}