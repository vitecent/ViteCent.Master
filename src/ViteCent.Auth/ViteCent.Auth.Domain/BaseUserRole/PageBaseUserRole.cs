#region

using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Auth.Entity.BaseUserRole;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserRole;

/// <summary>
/// </summary>
public class PageBaseUserRole : BaseDomain<BaseUserRoleEntity>, IRequestHandler<SearchBaseUserRoleEntityArgs, List<BaseUserRoleEntity>>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseUserRoleEntity>> Handle(SearchBaseUserRoleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}