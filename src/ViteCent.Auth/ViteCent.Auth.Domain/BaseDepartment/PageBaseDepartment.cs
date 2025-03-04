#region

using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseDepartment;

/// <summary>
/// </summary>
public class PageBaseDepartment : BaseDomain<BaseDepartmentEntity>, IRequestHandler<SearchBaseDepartmentEntityArgs, List<BaseDepartmentEntity>>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseDepartmentEntity>> Handle(SearchBaseDepartmentEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}