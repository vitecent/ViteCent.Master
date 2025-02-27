#region

using MediatR;
using ViteCent.Auth.Data.BaseRole;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseRole;

/// <summary>
///     GetBaseRole
/// </summary>
public class GetBaseRole : BaseDomain<BaseRoleEntity>, IRequestHandler<GetBaseRoleEntityArgs, BaseRoleEntity>
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
    public async Task<BaseRoleEntity> Handle(GetBaseRoleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id);
    }
}