#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseModuleField;

/// <summary>
/// </summary>
public class GetBaseModuleField : IRequestHandler<GetBaseModuleFieldArgs, DataResult<BaseModuleFieldResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseModuleField()
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
    public async Task<DataResult<BaseModuleFieldResult>> Handle(GetBaseModuleFieldArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseModuleFieldEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseModuleFieldResult>(entity);

        return new DataResult<BaseModuleFieldResult>(dto);
        ;
    }
}