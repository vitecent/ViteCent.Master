#region

using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Basic.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseOperation;

/// <summary>
///     PageBaseOperation
/// </summary>
public class PageBaseOperation : BaseDomain<BaseOperationEntity>, IRequestHandler<SearchBaseOperationEntityArgs, List<BaseOperationEntity>>
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
    public async Task<List<BaseOperationEntity>> Handle(SearchBaseOperationEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}