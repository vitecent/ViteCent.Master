#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseResource;

/// <summary>
/// </summary>
public class PageBaseResource : IRequestHandler<SearchBaseResourceArgs, PageResult<BaseResourceResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseResource()
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
    public async Task<PageResult<BaseResourceResult>> Handle(SearchBaseResourceArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseResourceEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseResourceResult>>(list);

        var result = new PageResult<BaseResourceResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}