#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUser;

/// <summary>
///     GetBaseUser
/// </summary>
public class GetBaseUser : IRequestHandler<GetBaseUserArgs, DataResult<BaseUserResult>>
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
    ///     GetBaseUser
    /// </summary>
    public GetBaseUser()
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
    public async Task<DataResult<BaseUserResult>> Handle(GetBaseUserArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseUserEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseUserResult>(entity);

        return new DataResult<BaseUserResult>(dto);
        ;
    }
}