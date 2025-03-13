#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUser;

/// <summary>
/// </summary>
public class DeleteBaseUser : IRequestHandler<DeleteBaseUserArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    private readonly BaseUserInfo user;

    /// <summary>
    /// </summary>
    public DeleteBaseUser()
    {
        var context = BaseHttpContext.Context;

        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;

        var json = context.User.FindFirstValue(ClaimTypes.UserData);

        if (!string.IsNullOrWhiteSpace(json))
            user = json.DeJson<BaseUserInfo>();
        else
            user = new BaseUserInfo();
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(DeleteBaseUserArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<DeleteBaseUserEntityArgs>(request);
        args.CompanyId = user?.Company?.Id ?? string.Empty;

        return await mediator.Send(args, cancellationToken);
    }
}