#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUser;

/// <summary>
///     AddBaseUser
/// </summary>
public class AddBaseUser : BaseDomain<BaseUserEntity>, IRequestHandler<BaseUserEntity, BaseResult>
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
    public async Task<BaseResult> Handle(BaseUserEntity request, CancellationToken cancellationToken)
    {
        return await base.AddAsync(request);
    }
}