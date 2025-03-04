#region

using MediatR;
using ViteCent.Auth.Data.BaseCompany;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseCompany;

/// <summary>
/// </summary>
public class PageBaseCompany : BaseDomain<BaseCompanyEntity>, IRequestHandler<SearchBaseCompanyEntityArgs, List<BaseCompanyEntity>>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseCompanyEntity>> Handle(SearchBaseCompanyEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}