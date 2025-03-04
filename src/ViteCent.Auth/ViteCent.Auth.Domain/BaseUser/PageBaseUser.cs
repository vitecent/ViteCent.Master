#region

using MediatR;
using ViteCent.Auth.Data.BaseUser;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUser;

/// <summary>
/// </summary>
public class PageBaseUser : BaseDomain<BaseUserEntity>, IRequestHandler<SearchBaseUserEntityArgs, List<BaseUserEntity>>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseUserEntity>> Handle(SearchBaseUserEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}