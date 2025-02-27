#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserRole;

/// <summary>
///     GetBaseUserRole
/// </summary>
public class GetBaseUserRole : IRequestHandler<GetBaseUserRoleArgs, DataResult<BaseUserRoleResult>>
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
    ///     GetBaseUserRole
    /// </summary>
    public GetBaseUserRole()
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
    public async Task<DataResult<BaseUserRoleResult>> Handle(GetBaseUserRoleArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseUserRoleEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseUserRoleResult>(entity);

        return new DataResult<BaseUserRoleResult>(dto);
        ;
    }
}