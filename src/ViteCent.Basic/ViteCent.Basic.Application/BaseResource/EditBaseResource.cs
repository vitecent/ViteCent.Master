#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseResource;

/// <summary>
///     EditBaseResource
/// </summary>
public class EditBaseResource : IRequestHandler<EditBaseResourceArgs, BaseResult>
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
    ///     EditBaseResource
    /// </summary>
    public EditBaseResource()
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
    public async Task<BaseResult> Handle(EditBaseResourceArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseResourceEntityArgs>(request);

        var entity = await _mediator.Send(args);

        entity.Updater = "Admin";
        entity.UpdateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}