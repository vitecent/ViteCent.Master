#region

using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseDepartment;

/// <summary>
///     PageBaseDepartment
/// </summary>
public class PageBaseDepartment : BaseDomain<BaseDepartmentEntity>, IRequestHandler<SearchBaseDepartmentEntityArgs, List<BaseDepartmentEntity>>
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
    public async Task<List<BaseDepartmentEntity>> Handle(SearchBaseDepartmentEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}