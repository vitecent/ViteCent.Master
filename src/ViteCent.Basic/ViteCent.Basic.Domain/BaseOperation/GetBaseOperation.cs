#region

using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Basic.Entity.BaseOperation;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseOperation;

/// <summary>
/// </summary>
public class GetBaseOperation : BaseDomain<BaseOperationEntity>, IRequestHandler<GetBaseOperationEntityArgs, BaseOperationEntity>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseOperationEntity> Handle(GetBaseOperationEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}