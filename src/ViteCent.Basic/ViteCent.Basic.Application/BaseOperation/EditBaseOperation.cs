#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseOperation;

/// <summary>
///     EditBaseOperation
/// </summary>
public class EditBaseOperation : IRequestHandler<EditBaseOperationArgs, BaseResult>
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
    ///     EditBaseOperation
    /// </summary>
    public EditBaseOperation()
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
    public async Task<BaseResult> Handle(EditBaseOperationArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseOperationEntityArgs>(request);

        var entity = await _mediator.Send(args);

        entity.Updater = "Admin";
        entity.UpdateTime = DateTime.Now;

        return await _mediator.Send(entity);
    }
}