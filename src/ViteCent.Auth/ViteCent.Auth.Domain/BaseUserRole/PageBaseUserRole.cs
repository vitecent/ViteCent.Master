#region

using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserRole;

/// <summary>
///     PageBaseUserRole
/// </summary>
public class PageBaseUserRole : BaseDomain<BaseUserRoleEntity>, IRequestHandler<SearchBaseUserRoleEntityArgs, List<BaseUserRoleEntity>>
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
    public async Task<List<BaseUserRoleEntity>> Handle(SearchBaseUserRoleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}