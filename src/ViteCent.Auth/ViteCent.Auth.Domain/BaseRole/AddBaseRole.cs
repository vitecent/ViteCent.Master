#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseRole;

/// <summary>
/// </summary>
public class AddBaseRole : BaseDomain<BaseRoleEntity>, IRequestHandler<AddBaseRoleEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(AddBaseRoleEntity request, CancellationToken cancellationToken)
    {
        return await base.AddAsync(request);
    }
}