#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModule;

/// <summary>
/// </summary>
public class PageBaseModule : IRequestHandler<SearchBaseModuleArgs, PageResult<BaseModuleResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseModule()
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
    public async Task<PageResult<BaseModuleResult>> Handle(SearchBaseModuleArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseModuleEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseModuleResult>>(list);

        var result = new PageResult<BaseModuleResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}