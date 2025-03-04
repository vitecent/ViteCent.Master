#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseDepartment;

/// <summary>
/// </summary>
public class EditBaseDepartment : BaseDomain<BaseDepartmentEntity>, IRequestHandler<BaseDepartmentEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseDepartmentEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}