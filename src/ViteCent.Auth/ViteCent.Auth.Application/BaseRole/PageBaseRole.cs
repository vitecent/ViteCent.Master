#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRole;

/// <summary>
///     PageBaseRole
/// </summary>
public class PageBaseRole : IRequestHandler<SearchBaseRoleArgs, PageResult<BaseRoleResult>>
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
    ///     PageBaseRole
    /// </summary>
    public PageBaseRole()
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
    public async Task<PageResult<BaseRoleResult>> Handle(SearchBaseRoleArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseRoleEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseRoleResult>>(list);

        var result = new PageResult<BaseRoleResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}