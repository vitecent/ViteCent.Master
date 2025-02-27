#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseCompany;

/// <summary>
///     EditBaseCompany
/// </summary>
public class EditBaseCompany : BaseDomain<BaseCompanyEntity>, IRequestHandler<BaseCompanyEntity, BaseResult>
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
    public async Task<BaseResult> Handle(BaseCompanyEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}