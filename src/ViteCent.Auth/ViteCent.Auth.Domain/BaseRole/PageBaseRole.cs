#region

using MediatR;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseRole;

/// <summary>
///     PageBaseRole
/// </summary>
public class PageBaseRole : BaseDomain<BaseRoleEntity>, IRequestHandler<SearchBaseRoleEntityArgs, List<BaseRoleEntity>>
{
    /// <summary>
    ///     DataBaseName
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    ///     Handle
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseRoleEntity>> Handle(SearchBaseRoleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}