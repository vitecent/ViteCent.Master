#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRole;

/// <summary>
///     GetBaseRole
/// </summary>
public class GetBaseRole : IRequestHandler<GetBaseRoleArgs, DataResult<BaseRoleResult>>
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
    ///     GetBaseRole
    /// </summary>
    public GetBaseRole()
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
    public async Task<DataResult<BaseRoleResult>> Handle(GetBaseRoleArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseRoleEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseRoleResult>(entity);

        return new DataResult<BaseRoleResult>(dto);
        ;
    }
}