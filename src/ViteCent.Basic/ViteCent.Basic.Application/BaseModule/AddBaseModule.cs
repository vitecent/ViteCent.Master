#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModule;

/// <summary>
///     AddBaseModule
/// </summary>
public class AddBaseModule : IRequestHandler<AddBaseModuleArgs, BaseResult>
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
    ///     AddBaseModule
    /// </summary>
    public AddBaseModule()
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
    public async Task<BaseResult> Handle(AddBaseModuleArgs request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<BaseModuleEntity>(request);

        entity.Id = Guid.NewGuid().ToString("N");
        entity.Creator = "Admin";
        entity.CreateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}