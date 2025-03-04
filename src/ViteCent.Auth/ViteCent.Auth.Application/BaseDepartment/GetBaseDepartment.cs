#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseDepartment;

/// <summary>
/// </summary>
public class GetBaseDepartment : IRequestHandler<GetBaseDepartmentArgs, DataResult<BaseDepartmentResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseDepartment()
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
    public async Task<DataResult<BaseDepartmentResult>> Handle(GetBaseDepartmentArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseDepartmentEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseDepartmentResult>(entity);

        return new DataResult<BaseDepartmentResult>(dto);
        ;
    }
}