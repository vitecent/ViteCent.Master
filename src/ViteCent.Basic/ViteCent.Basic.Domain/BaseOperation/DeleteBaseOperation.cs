#region

using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Basic.Entity.BaseOperation;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseOperation;

/// <summary>
/// </summary>
public class DeleteBaseOperation : BaseDomain<BaseOperationEntity>, IRequestHandler<DeleteBaseOperationEntityArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(DeleteBaseOperationEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.DeleteAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}