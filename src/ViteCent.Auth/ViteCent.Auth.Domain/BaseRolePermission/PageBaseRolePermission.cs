#region

using MediatR;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseRolePermission;

/// <summary>
///     PageBaseRolePermission
/// </summary>
public class PageBaseRolePermission : BaseDomain<BaseRolePermissionEntity>, IRequestHandler<SearchBaseRolePermissionEntityArgs, List<BaseRolePermissionEntity>>
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
    public async Task<List<BaseRolePermissionEntity>> Handle(SearchBaseRolePermissionEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}