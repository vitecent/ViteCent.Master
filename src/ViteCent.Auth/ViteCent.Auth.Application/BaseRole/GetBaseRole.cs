#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRole;

/// <summary>
/// </summary>
public class GetBaseRole : IRequestHandler<GetBaseRoleArgs, DataResult<BaseRoleResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseRole()
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
    public async Task<DataResult<BaseRoleResult>> Handle(GetBaseRoleArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseRoleEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseRoleResult>(entity);

        return new DataResult<BaseRoleResult>(dto);
        ;
    }
}