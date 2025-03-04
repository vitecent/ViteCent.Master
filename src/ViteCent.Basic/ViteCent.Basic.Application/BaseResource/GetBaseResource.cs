#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseResource;

/// <summary>
/// </summary>
public class GetBaseResource : IRequestHandler<GetBaseResourceArgs, DataResult<BaseResourceResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseResource()
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
    public async Task<DataResult<BaseResourceResult>> Handle(GetBaseResourceArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseResourceEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseResourceResult>(entity);

        return new DataResult<BaseResourceResult>(dto);
        ;
    }
}