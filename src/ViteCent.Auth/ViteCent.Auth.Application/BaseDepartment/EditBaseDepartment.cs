#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseDepartment;

/// <summary>
/// </summary>
public class EditBaseDepartment : IRequestHandler<EditBaseDepartmentArgs, BaseResult>
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
    public EditBaseDepartment()
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
    public async Task<BaseResult> Handle(EditBaseDepartmentArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseDepartmentEntityArgs>(request);

        var entity = await mediator.Send(args);

        entity.Abbreviation = request.Abbreviation; 
        entity.Code = request.Code; 
        entity.Description = request.Description; 
        entity.Level = request.Level; 
        entity.Manager = request.Manager; 
        entity.ManagerPhone = request.ManagerPhone; 
        entity.Name = request.Name; 
        entity.ParentId = request.ParentId; 
        entity.Status = request.Status; 
        entity.Updater = user?.Name ?? string.Empty;;
        entity.UpdateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity);
    }
}