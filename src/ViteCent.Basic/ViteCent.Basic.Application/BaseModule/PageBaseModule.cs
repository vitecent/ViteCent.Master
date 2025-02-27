#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModule;

/// <summary>
///     PageBaseModule
/// </summary>
public class PageBaseModule : IRequestHandler<SearchBaseModuleArgs, PageResult<BaseModuleResult>>
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
    ///     PageBaseModule
    /// </summary>
    public PageBaseModule()
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
    public async Task<PageResult<BaseModuleResult>> Handle(SearchBaseModuleArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseModuleEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseModuleResult>>(list);

        var result = new PageResult<BaseModuleResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}