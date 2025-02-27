#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRolePermission;

/// <summary>
///     GetBaseRolePermission
/// </summary>
public class GetBaseRolePermission : IRequestHandler<GetBaseRolePermissionArgs, DataResult<BaseRolePermissionResult>>
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
    ///     GetBaseRolePermission
    /// </summary>
    public GetBaseRolePermission()
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
    public async Task<DataResult<BaseRolePermissionResult>> Handle(GetBaseRolePermissionArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseRolePermissionEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseRolePermissionResult>(entity);

        return new DataResult<BaseRolePermissionResult>(dto);
        ;
    }
}