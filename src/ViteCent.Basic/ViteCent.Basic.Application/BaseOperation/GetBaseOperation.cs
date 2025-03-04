#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseOperation;

/// <summary>
/// </summary>
public class GetBaseOperation : IRequestHandler<GetBaseOperationArgs, DataResult<BaseOperationResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseOperation()
    {
        var context = BaseHttpContext.Context;

        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;
        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<DataResult<BaseOperationResult>> Handle(GetBaseOperationArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseOperationEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseOperationResult>(entity);

        return new DataResult<BaseOperationResult>(dto);
        ;
    }
}