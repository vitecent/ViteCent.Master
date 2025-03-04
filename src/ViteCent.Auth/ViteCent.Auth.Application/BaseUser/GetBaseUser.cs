#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUser;

/// <summary>
/// </summary>
public class GetBaseUser : IRequestHandler<GetBaseUserArgs, DataResult<BaseUserResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseUser()
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
    public async Task<DataResult<BaseUserResult>> Handle(GetBaseUserArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseUserEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseUserResult>(entity);

        return new DataResult<BaseUserResult>(dto);
        ;
    }
}