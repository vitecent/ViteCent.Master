#region

using MediatR;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserDepartment;

/// <summary>
///     PageBaseUserDepartment
/// </summary>
public class PageBaseUserDepartment : BaseDomain<BaseUserDepartmentEntity>, IRequestHandler<SearchBaseUserDepartmentEntityArgs, List<BaseUserDepartmentEntity>>
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
    public async Task<List<BaseUserDepartmentEntity>> Handle(SearchBaseUserDepartmentEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}