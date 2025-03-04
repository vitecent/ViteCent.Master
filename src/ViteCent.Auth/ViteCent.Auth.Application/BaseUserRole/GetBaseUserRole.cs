#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserRole;

/// <summary>
/// </summary>
public class GetBaseUserRole : IRequestHandler<GetBaseUserRoleArgs, DataResult<BaseUserRoleResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseUserRole()
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
    public async Task<DataResult<BaseUserRoleResult>> Handle(GetBaseUserRoleArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseUserRoleEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseUserRoleResult>(entity);

        return new DataResult<BaseUserRoleResult>(dto);
        ;
    }
}