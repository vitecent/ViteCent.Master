#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserRole;

/// <summary>
/// </summary>
public class PageBaseUserRole : IRequestHandler<SearchBaseUserRoleArgs, PageResult<BaseUserRoleResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseUserRole()
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
    public async Task<PageResult<BaseUserRoleResult>> Handle(SearchBaseUserRoleArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseUserRoleEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseUserRoleResult>>(list);

        var result = new PageResult<BaseUserRoleResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}