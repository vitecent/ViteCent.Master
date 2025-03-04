#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRolePermission;

/// <summary>
/// </summary>
public class PageBaseRolePermission : IRequestHandler<SearchBaseRolePermissionArgs, PageResult<BaseRolePermissionResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseRolePermission()
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
    public async Task<PageResult<BaseRolePermissionResult>> Handle(SearchBaseRolePermissionArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseRolePermissionEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseRolePermissionResult>>(list);

        var result = new PageResult<BaseRolePermissionResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}