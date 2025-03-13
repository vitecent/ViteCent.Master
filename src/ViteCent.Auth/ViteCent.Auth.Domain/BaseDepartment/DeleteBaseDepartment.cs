#region

using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Entity.BaseDepartment;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseDepartment;

/// <summary>
/// </summary>
public class DeleteBaseDepartment : BaseDomain<BaseDepartmentEntity>, IRequestHandler<DeleteBaseDepartmentEntityArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(DeleteBaseDepartmentEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.DeleteAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}