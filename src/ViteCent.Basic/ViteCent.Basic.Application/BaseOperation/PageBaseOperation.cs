#region

using AutoMapper;
using MediatR;
using System.Security.Claims;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Core;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Application.BaseOperation;

/// <summary>
/// </summary>
public class PageBaseOperation : IRequestHandler<SearchBaseOperationArgs, PageResult<BaseOperationResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    private readonly BaseUserInfo user;

    /// <summary>
    /// </summary>
    public PageBaseOperation()
    {
        var context = BaseHttpContext.Context;

        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;

        var json = context.User.FindFirstValue(ClaimTypes.UserData);

        if (!string.IsNullOrWhiteSpace(json))
            user = json.DeJson<BaseUserInfo>();
        else
            user = new BaseUserInfo();
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<PageResult<BaseOperationResult>> Handle(SearchBaseOperationArgs request,
        CancellationToken cancellationToken)
    {
        var args = mapper.Map<SearchBaseOperationEntityArgs>(request);

        args.Args.RemoveAll(x => x.Field == "CompanyId");
        args.Args.Add(new SearchItem()
        {
            Field = "CompanyId",
            Value = user?.Company?.Id ?? string.Empty,
        });

        var list = await mediator.Send(args, cancellationToken);

        var rows = mapper.Map<List<BaseOperationResult>>(list);

        var result = new PageResult<BaseOperationResult>(args.Offset, args.Limit, args.Total, rows);

        return result;
    }
}