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
public class EditBaseUser : IRequestHandler<EditBaseUserArgs, BaseResult>
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
    public EditBaseUser()
    {
        var context = BaseHttpContext.Context;

        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;
        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;

        var json = context.User.FindFirstValue(ClaimTypes.UserData);

        if (!string.IsNullOrWhiteSpace(json))
            user = json.DeJson<BaseUserInfo>();
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(EditBaseUserArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseUserEntityArgs>(request);

        var entity = await mediator.Send(args);

        entity.Avatar = request.Avatar; 
        entity.Birthday = request.Birthday; 
        entity.Description = request.Description; 
        entity.Email = request.Email; 
        entity.Gender = request.Gender; 
        entity.IdCard = request.IdCard; 
        entity.Nickname = request.Nickname; 
        entity.Password = request.Password; 
        entity.Phone = request.Phone; 
        entity.RealName = request.RealName; 
        entity.Status = request.Status; 
        entity.Username = request.Username; 
        entity.UserNo = request.UserNo; 
        entity.Updater = user?.Name ?? string.Empty;;
        entity.UpdateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity);
    }
}