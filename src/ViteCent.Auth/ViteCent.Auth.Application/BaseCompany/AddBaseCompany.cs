#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseCompany;

/// <summary>
///     AddBaseCompany
/// </summary>
public class AddBaseCompany : IRequestHandler<AddBaseCompanyArgs, BaseResult>
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
    ///     AddBaseCompany
    /// </summary>
    public AddBaseCompany()
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
    public async Task<BaseResult> Handle(AddBaseCompanyArgs request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<BaseCompanyEntity>(request);

        entity.Id = Guid.NewGuid().ToString("N");
        entity.Creator = "Admin";
        entity.CreateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}