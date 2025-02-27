#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseResource;

/// <summary>
///     GetBaseResource
/// </summary>
public class GetBaseResource : IRequestHandler<GetBaseResourceArgs, DataResult<BaseResourceResult>>
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
    ///     GetBaseResource
    /// </summary>
    public GetBaseResource()
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
    public async Task<DataResult<BaseResourceResult>> Handle(GetBaseResourceArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseResourceEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseResourceResult>(entity);

        return new DataResult<BaseResourceResult>(dto);
        ;
    }
}