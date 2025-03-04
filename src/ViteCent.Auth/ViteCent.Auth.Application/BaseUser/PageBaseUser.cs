#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseUser;

/// <summary>
/// </summary>
public class PageBaseUser : IRequestHandler<SearchBaseUserArgs, PageResult<BaseUserResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public PageBaseUser()
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
    public async Task<PageResult<BaseUserResult>> Handle(SearchBaseUserArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseUserEntityArgs>(request);

        var list = await mediator.Send(args);

        var rows = mapper.Map<List<BaseUserResult>>(list);

        var result = new PageResult<BaseUserResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}