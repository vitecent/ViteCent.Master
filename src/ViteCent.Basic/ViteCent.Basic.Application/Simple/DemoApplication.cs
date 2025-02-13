﻿#region

using AutoMapper;
using MediatR;
using ViteCent.Basic.Data.Simple;
using ViteCent.Basic.Domain;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Application.Simple;

/// <summary>
/// </summary>
public class DemoApplication : BaseApplication<SimpleEntity>, IRequestHandler<SimpleArgs, PageResult<SimpleResult>>
{
    /// <summary>
    /// </summary>
    private readonly SimpleDomain _domain;

    /// <summary>
    /// </summary>
    private readonly IMapper _mapper;

    /// <summary>
    /// </summary>
    public DemoApplication()
    {
        _domain = new SimpleDomain();

        var context = BaseHttpContext.Context;
        _mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
    }

    /// <summary>
    /// </summary>
    public override IBaseDomain<SimpleEntity> Domain => _domain;

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<PageResult<SimpleResult>> Handle(SimpleArgs request, CancellationToken cancellationToken)
    {
        var entity = await base.PageAsync(request);

        var result = _mapper.Map<List<SimpleResult>>(entity);

        return new PageResult<SimpleResult>(request.Offset, request.Limit, request.Total, result);
    }
}