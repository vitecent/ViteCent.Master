#region

using MediatR;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Basic.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModule;

/// <summary>
/// </summary>
public class PageBaseModule : BaseDomain<BaseModuleEntity>, IRequestHandler<SearchBaseModuleEntityArgs, List<BaseModuleEntity>>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseModuleEntity>> Handle(SearchBaseModuleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}