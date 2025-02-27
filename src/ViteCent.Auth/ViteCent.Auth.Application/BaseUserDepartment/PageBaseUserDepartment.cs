#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserDepartment;

/// <summary>
///     PageBaseUserDepartment
/// </summary>
public class PageBaseUserDepartment : IRequestHandler<SearchBaseUserDepartmentArgs, PageResult<BaseUserDepartmentResult>>
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
    ///     PageBaseUserDepartment
    /// </summary>
    public PageBaseUserDepartment()
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
    public async Task<PageResult<BaseUserDepartmentResult>> Handle(SearchBaseUserDepartmentArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseUserDepartmentEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseUserDepartmentResult>>(list);

        var result = new PageResult<BaseUserDepartmentResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}