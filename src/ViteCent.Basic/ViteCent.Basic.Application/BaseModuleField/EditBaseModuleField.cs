#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModuleField;

/// <summary>
/// </summary>
public class EditBaseModuleField : IRequestHandler<EditBaseModuleFieldArgs, BaseResult>
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
    public EditBaseModuleField()
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
    public async Task<BaseResult> Handle(EditBaseModuleFieldArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseModuleFieldEntityArgs>(request);

        var entity = await mediator.Send(args);

        entity.Abbreviation = request.Abbreviation; 
        entity.AddOrder = request.AddOrder; 
        entity.AddWidth = request.AddWidth; 
        entity.AllowNull = request.AllowNull; 
        entity.Code = request.Code; 
        entity.DataType = request.DataType; 
        entity.Description = request.Description; 
        entity.DetailsOrder = request.DetailsOrder; 
        entity.DetailsWidth = request.DetailsWidth; 
        entity.ExportOrder = request.ExportOrder; 
        entity.ExportWidth = request.ExportWidth; 
        entity.IsIndex = request.IsIndex; 
        entity.IsUnique = request.IsUnique; 
        entity.ListOrder = request.ListOrder; 
        entity.ListWidth = request.ListWidth; 
        entity.MaxLength = request.MaxLength; 
        entity.MinLength = request.MinLength; 
        entity.ModuleId = request.ModuleId; 
        entity.Name = request.Name; 
        entity.PrintOrder = request.PrintOrder; 
        entity.PrintWidth = request.PrintWidth; 
        entity.SearchOrder = request.SearchOrder; 
        entity.SearchWidth = request.SearchWidth; 
        entity.ShowInAdd = request.ShowInAdd; 
        entity.ShowInDetails = request.ShowInDetails; 
        entity.ShowInExport = request.ShowInExport; 
        entity.ShowInList = request.ShowInList; 
        entity.ShowInPrint = request.ShowInPrint; 
        entity.ShowInSearch = request.ShowInSearch; 
        entity.ShowInUpdate = request.ShowInUpdate; 
        entity.Status = request.Status; 
        entity.UpdateOrder = request.UpdateOrder; 
        entity.UpdateWidth = request.UpdateWidth; 
        entity.Updater = user?.Name ?? string.Empty;;
        entity.UpdateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity);
    }
}