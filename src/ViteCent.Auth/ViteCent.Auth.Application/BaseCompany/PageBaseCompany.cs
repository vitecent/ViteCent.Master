#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseCompany;

/// <summary>
/// </summary>
public class PageBaseCompany : IRequestHandler<SearchBaseCompanyArgs, PageResult<BaseCompanyResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseCompany()
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
    public async Task<PageResult<BaseCompanyResult>> Handle(SearchBaseCompanyArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseCompanyEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseCompanyResult>>(list);

        var result = new PageResult<BaseCompanyResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}