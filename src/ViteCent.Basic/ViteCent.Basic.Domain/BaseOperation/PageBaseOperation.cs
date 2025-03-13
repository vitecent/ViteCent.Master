#region

using MediatR;
using ViteCent.Basic.Data.BaseOperation;
using ViteCent.Basic.Entity.BaseOperation;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseOperation;

/// <summary>
/// </summary>
public class PageBaseOperation : BaseDomain<BaseOperationEntity>, IRequestHandler<SearchBaseOperationEntityArgs, List<BaseOperationEntity>>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<BaseOperationEntity>> Handle(SearchBaseOperationEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.PageAsync(request);
    }
}