#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModuleField;

/// <summary>
/// </summary>
public class PageBaseModuleField : IRequestHandler<SearchBaseModuleFieldArgs, PageResult<BaseModuleFieldResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseModuleField()
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
    public async Task<PageResult<BaseModuleFieldResult>> Handle(SearchBaseModuleFieldArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseModuleFieldEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseModuleFieldResult>>(list);

        var result = new PageResult<BaseModuleFieldResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}