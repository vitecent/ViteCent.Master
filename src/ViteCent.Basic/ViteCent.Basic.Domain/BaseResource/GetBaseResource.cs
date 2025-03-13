#region

using MediatR;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Basic.Entity.BaseResource;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseResource;

/// <summary>
/// </summary>
public class GetBaseResource : BaseDomain<BaseResourceEntity>, IRequestHandler<GetBaseResourceEntityArgs, BaseResourceEntity>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResourceEntity> Handle(GetBaseResourceEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}