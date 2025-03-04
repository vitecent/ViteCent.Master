#region

using MediatR;
using ViteCent.Auth.Data.BaseRolePermission;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseRolePermission;

/// <summary>
/// </summary>
public class GetBaseRolePermission : BaseDomain<BaseRolePermissionEntity>, IRequestHandler<GetBaseRolePermissionEntityArgs, BaseRolePermissionEntity>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseRolePermissionEntity> Handle(GetBaseRolePermissionEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id);
    }
}