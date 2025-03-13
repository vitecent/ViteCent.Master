#region

using MediatR;
using ViteCent.Auth.Entity.BaseRolePermission;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseRolePermission;

/// <summary>
/// </summary>
public class EditBaseRolePermission : BaseDomain<BaseRolePermissionEntity>, IRequestHandler<BaseRolePermissionEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseRolePermissionEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}