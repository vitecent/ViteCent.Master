#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserDepartment;

/// <summary>
///     GetBaseUserDepartment
/// </summary>
public class GetBaseUserDepartment : IRequestHandler<GetBaseUserDepartmentArgs, DataResult<BaseUserDepartmentResult>>
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
    ///     GetBaseUserDepartment
    /// </summary>
    public GetBaseUserDepartment()
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
    public async Task<DataResult<BaseUserDepartmentResult>> Handle(GetBaseUserDepartmentArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseUserDepartmentEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseUserDepartmentResult>(entity);

        return new DataResult<BaseUserDepartmentResult>(dto);
        ;
    }
}