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
public class GetBaseOperation : IRequestHandler<GetBaseOperationArgs, DataResult<BaseOperationResult>>
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
    public GetBaseOperation()
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
    public async Task<DataResult<BaseOperationResult>> Handle(GetBaseOperationArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseOperationEntityArgs>(request);
        args.CompanyId = user?.Company?.Id ?? string.Empty;

        var entity = await mediator.Send(args, cancellationToken);

        var dto = mapper.Map<BaseOperationResult>(entity);

        return new DataResult<BaseOperationResult>(dto);
    }
}