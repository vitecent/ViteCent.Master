#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserDepartment;

/// <summary>
/// </summary>
public class EditBaseUserDepartment : IRequestHandler<EditBaseUserDepartmentArgs, BaseResult>
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
    public EditBaseUserDepartment()
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
    public async Task<BaseResult> Handle(EditBaseUserDepartmentArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseUserDepartmentEntityArgs>(request);
        args.CompanyId = user?.Company?.Id ?? string.Empty;

        var entity = await mediator.Send(args, cancellationToken);

        entity.DepartmentId = request.DepartmentId;
        entity.Status = request.Status;
        entity.UserId = request.UserId;
        entity.CompanyId = user?.Company?.Id ?? string.Empty;
        entity.Updater = user?.Name ?? string.Empty;
        entity.UpdateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity, cancellationToken);
    }
}