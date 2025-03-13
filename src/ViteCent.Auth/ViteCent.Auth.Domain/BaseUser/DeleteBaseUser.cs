#region

using MediatR;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Auth.Entity.BaseUser;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUser;

/// <summary>
/// </summary>
public class DeleteBaseUser : BaseDomain<BaseUserEntity>, IRequestHandler<DeleteBaseUserEntityArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(DeleteBaseUserEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.DeleteAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}