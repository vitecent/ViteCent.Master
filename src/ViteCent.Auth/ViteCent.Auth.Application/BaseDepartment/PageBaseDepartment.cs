#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseDepartment;

/// <summary>
/// </summary>
public class PageBaseDepartment : IRequestHandler<SearchBaseDepartmentArgs, PageResult<BaseDepartmentResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseDepartment()
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
    public async Task<PageResult<BaseDepartmentResult>> Handle(SearchBaseDepartmentArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseDepartmentEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseDepartmentResult>>(list);

        var result = new PageResult<BaseDepartmentResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}