#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserRole;

/// <summary>
///     AddBaseUserRole
/// </summary>
public class AddBaseUserRole : IRequestHandler<AddBaseUserRoleArgs, BaseResult>
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
    ///     AddBaseUserRole
    /// </summary>
    public AddBaseUserRole()
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
    public async Task<BaseResult> Handle(AddBaseUserRoleArgs request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<BaseUserRoleEntity>(request);

        entity.Id = Guid.NewGuid().ToString("N");
        entity.Creator = "Admin";
        entity.CreateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}