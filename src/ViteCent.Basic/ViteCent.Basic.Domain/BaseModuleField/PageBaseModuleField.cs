#region

using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Basic.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModuleField;

/// <summary>
///     PageBaseModuleField
/// </summary>
public class PageBaseModuleField : BaseDomain<BaseModuleFieldEntity>, IRequestHandler<SearchBaseModuleFieldEntityArgs, List<BaseModuleFieldEntity>>
{
    /// <summary>
    ///     DataBaseName
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    ///     Handle
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseModuleFieldEntity>> Handle(SearchBaseModuleFieldEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}