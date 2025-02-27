#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserRole;

/// <summary>
///     PageBaseUserRole
/// </summary>
public class PageBaseUserRole : IRequestHandler<SearchBaseUserRoleArgs, PageResult<BaseUserRoleResult>>
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
    ///     PageBaseUserRole
    /// </summary>
    public PageBaseUserRole()
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
    public async Task<PageResult<BaseUserRoleResult>> Handle(SearchBaseUserRoleArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseUserRoleEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseUserRoleResult>>(list);

        var result = new PageResult<BaseUserRoleResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}