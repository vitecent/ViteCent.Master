#region

using MediatR;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserDepartment;

/// <summary>
///     GetBaseUserDepartment
/// </summary>
public class GetBaseUserDepartment : BaseDomain<BaseUserDepartmentEntity>, IRequestHandler<GetBaseUserDepartmentEntityArgs, BaseUserDepartmentEntity>
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
    public async Task<BaseUserDepartmentEntity> Handle(GetBaseUserDepartmentEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id);
    }
}