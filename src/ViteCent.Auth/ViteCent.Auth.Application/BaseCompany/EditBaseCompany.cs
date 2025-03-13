#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseCompany;

/// <summary>
/// </summary>
public class EditBaseCompany : IRequestHandler<EditBaseCompanyArgs, BaseResult>
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
    public EditBaseCompany()
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
    public async Task<BaseResult> Handle(EditBaseCompanyArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseCompanyEntityArgs>(request);

        var entity = await mediator.Send(args, cancellationToken);

        entity.Abbreviation = request.Abbreviation;
        entity.Address = request.Address;
        entity.City = request.City;
        entity.Code = request.Code;
        entity.Country = request.Country;
        entity.Description = request.Description;
        entity.Email = request.Email;
        entity.EstablishDate = request.EstablishDate;
        entity.Industry = request.Industry;
        entity.LegalPerson = request.LegalPerson;
        entity.LegalPhone = request.LegalPhone;
        entity.Level = request.Level;
        entity.Logo = request.Logo;
        entity.Name = request.Name;
        entity.ParentId = request.ParentId;
        entity.Province = request.Province;
        entity.Status = request.Status;
        entity.Updater = user?.Name ?? string.Empty;
        entity.UpdateTime = DateTime.Now;
        entity.DataVersion = DateTime.Now;

        return await mediator.Send(entity, cancellationToken);
    }
}