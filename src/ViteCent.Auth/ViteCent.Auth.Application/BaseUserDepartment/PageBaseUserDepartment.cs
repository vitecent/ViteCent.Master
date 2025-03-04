#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUserDepartment;

/// <summary>
/// </summary>
public class PageBaseUserDepartment : IRequestHandler<SearchBaseUserDepartmentArgs, PageResult<BaseUserDepartmentResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseUserDepartment()
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
    public async Task<PageResult<BaseUserDepartmentResult>> Handle(SearchBaseUserDepartmentArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseUserDepartmentEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseUserDepartmentResult>>(list);

        var result = new PageResult<BaseUserDepartmentResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}