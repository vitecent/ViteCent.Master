#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUser;

/// <summary>
///     PageBaseUser
/// </summary>
public class PageBaseUser : IRequestHandler<SearchBaseUserArgs, PageResult<BaseUserResult>>
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
    ///     PageBaseUser
    /// </summary>
    public PageBaseUser()
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
    public async Task<PageResult<BaseUserResult>> Handle(SearchBaseUserArgs request,
        CancellationToken cancellationToken)
    {
        var args = _mapper.Map<SearchBaseUserEntityArgs>(request);

        var list = await _mediator.Send(args);

        var rows = _mapper.Map<List<BaseUserResult>>(list);

        var result = new PageResult<BaseUserResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}