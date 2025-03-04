#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Entity;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseDepartment;

/// <summary>
/// </summary>
public class AddBaseDepartment : IRequestHandler<AddBaseDepartmentArgs, BaseResult>
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
    public AddBaseDepartment()
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
    public async Task<BaseResult> Handle(AddBaseDepartmentArgs request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<AddBaseDepartmentEntity>(request);

        entity.Id = Guid.NewGuid().ToString("N");
        entity.Creator = user?.Name ?? string.Empty;;
        entity.CreateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity);
    }
}