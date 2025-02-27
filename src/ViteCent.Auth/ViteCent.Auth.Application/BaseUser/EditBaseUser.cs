#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUser;

/// <summary>
///     EditBaseUser
/// </summary>
public class EditBaseUser : IRequestHandler<EditBaseUserArgs, BaseResult>
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
    ///     EditBaseUser
    /// </summary>
    public EditBaseUser()
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
    public async Task<BaseResult> Handle(EditBaseUserArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseUserEntityArgs>(request);

        var entity = await _mediator.Send(args);

        entity.Updater = "Admin";
        entity.UpdateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}