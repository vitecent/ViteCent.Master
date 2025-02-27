#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseRole;

/// <summary>
///     EditBaseRole
/// </summary>
public class EditBaseRole : IRequestHandler<EditBaseRoleArgs, BaseResult>
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
    ///     EditBaseRole
    /// </summary>
    public EditBaseRole()
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
    public async Task<BaseResult> Handle(EditBaseRoleArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseRoleEntityArgs>(request);

        var entity = await _mediator.Send(args);

        entity.Updater = "Admin";
        entity.UpdateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}