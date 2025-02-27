#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseDepartment;

/// <summary>
///     AddBaseDepartment
/// </summary>
public class AddBaseDepartment : IRequestHandler<AddBaseDepartmentArgs, BaseResult>
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
    ///     AddBaseDepartment
    /// </summary>
    public AddBaseDepartment()
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
    public async Task<BaseResult> Handle(AddBaseDepartmentArgs request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<BaseDepartmentEntity>(request);

        entity.Id = Guid.NewGuid().ToString("N");
        entity.Creator = "Admin";
        entity.CreateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}