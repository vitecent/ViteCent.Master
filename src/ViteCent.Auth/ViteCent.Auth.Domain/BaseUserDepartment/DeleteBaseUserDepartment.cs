#region

using MediatR;
using ViteCent.Auth.Data.BaseUserDepartment;
using ViteCent.Auth.Entity.BaseUserDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseUserDepartment;

/// <summary>
/// </summary>
public class DeleteBaseUserDepartment : BaseDomain<BaseUserDepartmentEntity>, IRequestHandler<DeleteBaseUserDepartmentEntityArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(DeleteBaseUserDepartmentEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.DeleteAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}