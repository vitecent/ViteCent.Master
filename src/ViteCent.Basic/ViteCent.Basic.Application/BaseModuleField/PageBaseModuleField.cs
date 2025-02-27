#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModuleField;

/// <summary>
///     PageBaseModuleField
/// </summary>
public class PageBaseModuleField : IRequestHandler<SearchBaseModuleFieldArgs, PageResult<BaseModuleFieldResult>>
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
    ///     PageBaseModuleField
    /// </summary>
    public PageBaseModuleField()
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
    public async Task<PageResult<BaseModuleFieldResult>> Handle(SearchBaseModuleFieldArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseModuleFieldEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseModuleFieldResult>>(list);

        var result = new PageResult<BaseModuleFieldResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}