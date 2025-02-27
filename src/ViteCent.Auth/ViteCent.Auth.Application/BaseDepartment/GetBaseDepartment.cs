#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseDepartment;

/// <summary>
///     GetBaseDepartment
/// </summary>
public class GetBaseDepartment : IRequestHandler<GetBaseDepartmentArgs, DataResult<BaseDepartmentResult>>
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
    ///     GetBaseDepartment
    /// </summary>
    public GetBaseDepartment()
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
    public async Task<DataResult<BaseDepartmentResult>> Handle(GetBaseDepartmentArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseDepartmentEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseDepartmentResult>(entity);

        return new DataResult<BaseDepartmentResult>(dto);
        ;
    }
}