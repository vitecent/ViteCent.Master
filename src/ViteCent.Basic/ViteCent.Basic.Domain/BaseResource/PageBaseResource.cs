#region

using MediatR;
using ViteCent.Basic.Data.BaseResource;
using ViteCent.Basic.Entity.BaseResource;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseResource;

/// <summary>
/// </summary>
public class PageBaseResource : BaseDomain<BaseResourceEntity>, IRequestHandler<SearchBaseResourceEntityArgs, List<BaseResourceEntity>>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseResourceEntity>> Handle(SearchBaseResourceEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}