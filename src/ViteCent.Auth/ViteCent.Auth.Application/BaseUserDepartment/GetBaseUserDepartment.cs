#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserDepartment;

/// <summary>
/// </summary>
public class GetBaseUserDepartment : IRequestHandler<GetBaseUserDepartmentArgs, DataResult<BaseUserDepartmentResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseUserDepartment()
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
    public async Task<DataResult<BaseUserDepartmentResult>> Handle(GetBaseUserDepartmentArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseUserDepartmentEntityArgs>(request);

        var entity = await mediator.Send(args);

        var dto = mapper.Map<BaseUserDepartmentResult>(entity);

        return new DataResult<BaseUserDepartmentResult>(dto);
        ;
    }
}