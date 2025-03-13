#region

using MediatR;
using ViteCent.Auth.Entity.BaseUserRole;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserRole;

/// <summary>
/// </summary>
public class EditBaseUserRole : BaseDomain<BaseUserRoleEntity>, IRequestHandler<BaseUserRoleEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseUserRoleEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}