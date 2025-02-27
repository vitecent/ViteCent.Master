#region

using AutoMapper;
using MediatR;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Application.BaseCompany;

/// <summary>
///     GetBaseCompany
/// </summary>
public class GetBaseCompany : IRequestHandler<GetBaseCompanyArgs, DataResult<BaseCompanyResult>>
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
    ///     GetBaseCompany
    /// </summary>
    public GetBaseCompany()
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
    public async Task<DataResult<BaseCompanyResult>> Handle(GetBaseCompanyArgs request, CancellationToken cancellationToken)
    {
        var args = _mapper.Map<GetBaseCompanyEntityArgs>(request);

        var entity = await _mediator.Send(args);

        var dto = _mapper.Map<BaseCompanyResult>(entity);

        return new DataResult<BaseCompanyResult>(dto);
        ;
    }
}