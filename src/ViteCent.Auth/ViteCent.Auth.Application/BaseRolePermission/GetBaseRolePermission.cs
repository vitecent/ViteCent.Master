#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRolePermission;

/// <summary>
/// </summary>
public class GetBaseRolePermission : IRequestHandler<GetBaseRolePermissionArgs, DataResult<BaseRolePermissionResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseRolePermission()
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
    public async Task<DataResult<BaseRolePermissionResult>> Handle(GetBaseRolePermissionArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseRolePermissionEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseRolePermissionResult>(entity);

        return new DataResult<BaseRolePermissionResult>(dto);
        ;
    }
}