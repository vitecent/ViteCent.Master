#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRolePermission;

/// <summary>
///     PageBaseRolePermission
/// </summary>
public class PageBaseRolePermission : IRequestHandler<SearchBaseRolePermissionArgs, PageResult<BaseRolePermissionResult>>
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
    ///     PageBaseRolePermission
    /// </summary>
    public PageBaseRolePermission()
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
    public async Task<PageResult<BaseRolePermissionResult>> Handle(SearchBaseRolePermissionArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseRolePermissionEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseRolePermissionResult>>(list);

        var result = new PageResult<BaseRolePermissionResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}