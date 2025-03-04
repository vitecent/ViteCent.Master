#region

using MediatR;
using ViteCent.Auth.Data.BaseDepartment;
using ViteCent.Auth.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Domain.BaseDepartment;

/// <summary>
/// </summary>
public class GetBaseDepartment : BaseDomain<BaseDepartmentEntity>, IRequestHandler<GetBaseDepartmentEntityArgs, BaseDepartmentEntity>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Auth";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseDepartmentEntity> Handle(GetBaseDepartmentEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id);
    }
}