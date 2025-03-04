#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseResource;

/// <summary>
/// </summary>
public class EditBaseResource : IRequestHandler<EditBaseResourceArgs, BaseResult>
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
    public EditBaseResource()
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
    public async Task<BaseResult> Handle(EditBaseResourceArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseResourceEntityArgs>(request);

        var entity = await mediator.Send(args);

        entity.Abbreviation = request.Abbreviation; 
        entity.Code = request.Code; 
        entity.Description = request.Description; 
        entity.Level = request.Level; 
        entity.ModuleId = request.ModuleId; 
        entity.Name = request.Name; 
        entity.ParentId = request.ParentId; 
        entity.Status = request.Status; 
        entity.Updater = user?.Name ?? string.Empty;;
        entity.UpdateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity);
    }
}