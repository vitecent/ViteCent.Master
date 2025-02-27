#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseCompany;

/// <summary>
///     PageBaseCompany
/// </summary>
public class PageBaseCompany : IRequestHandler<SearchBaseCompanyArgs, PageResult<BaseCompanyResult>>
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
    ///     PageBaseCompany
    /// </summary>
    public PageBaseCompany()
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
    public async Task<PageResult<BaseCompanyResult>> Handle(SearchBaseCompanyArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseCompanyEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseCompanyResult>>(list);

        var result = new PageResult<BaseCompanyResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}