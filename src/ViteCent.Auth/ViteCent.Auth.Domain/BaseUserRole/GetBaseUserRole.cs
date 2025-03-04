#region

using MediatR;
using ViteCent.Auth.Data.BaseUserRole;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserRole;

/// <summary>
/// </summary>
public class GetBaseUserRole : BaseDomain<BaseUserRoleEntity>, IRequestHandler<GetBaseUserRoleEntityArgs, BaseUserRoleEntity>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseUserRoleEntity> Handle(GetBaseUserRoleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id);
    }
}