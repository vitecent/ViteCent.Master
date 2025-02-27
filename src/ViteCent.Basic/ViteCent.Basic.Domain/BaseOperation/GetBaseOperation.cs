#region

using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Basic.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseOperation;

/// <summary>
///     GetBaseOperation
/// </summary>
public class GetBaseOperation : BaseDomain<BaseOperationEntity>, IRequestHandler<GetBaseOperationEntityArgs, BaseOperationEntity>
{
    /// <summary>
    ///     DataBaseName
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    ///     Handle
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseOperationEntity> Handle(GetBaseOperationEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id);
    }
}