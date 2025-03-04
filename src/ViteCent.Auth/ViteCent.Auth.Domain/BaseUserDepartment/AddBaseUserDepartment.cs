#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserDepartment;

/// <summary>
/// </summary>
public class AddBaseUserDepartment : BaseDomain<BaseUserDepartmentEntity>, IRequestHandler<AddBaseUserDepartmentEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(AddBaseUserDepartmentEntity request, CancellationToken cancellationToken)
    {
        return await base.AddAsync(request);
    }
}