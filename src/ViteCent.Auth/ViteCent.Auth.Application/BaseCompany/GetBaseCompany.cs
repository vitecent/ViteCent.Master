#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseCompany;

/// <summary>
/// </summary>
public class GetBaseCompany : IRequestHandler<GetBaseCompanyArgs, DataResult<BaseCompanyResult>>
{
    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// </summary>
    public GetBaseCompany()
    {
        var context = BaseHttpContext.Context;

        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
        mediator = context.RequestServices.GetService(typeof(IMediator)) as IMediator ?? default!;
    }

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<DataResult<BaseCompanyResult>> Handle(GetBaseCompanyArgs request, CancellationToken cancellationToken)
    {
        var args = mapper.Map<GetBaseCompanyEntityArgs>(request);

        var entity = await mediator.Send(args, cancellationToken);

        var dto = mapper.Map<BaseCompanyResult>(entity);

        return new DataResult<BaseCompanyResult>(dto);
    }
}