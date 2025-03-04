#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRole;

/// <summary>
/// </summary>
public class PageBaseRole : IRequestHandler<SearchBaseRoleArgs, PageResult<BaseRoleResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseRole()
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
    public async Task<PageResult<BaseRoleResult>> Handle(SearchBaseRoleArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseRoleEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseRoleResult>>(list);

        var result = new PageResult<BaseRoleResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}