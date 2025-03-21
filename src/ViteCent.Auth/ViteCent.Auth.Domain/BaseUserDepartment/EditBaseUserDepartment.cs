#region

using MediatR;
using ViteCent.Auth.Entity.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserDepartment;

/// <summary>
/// </summary>
public class EditBaseUserDepartment : BaseDomain<BaseUserDepartmentEntity>, IRequestHandler<BaseUserDepartmentEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseUserDepartmentEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}