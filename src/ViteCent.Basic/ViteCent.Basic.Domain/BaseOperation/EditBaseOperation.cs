#region

using MediatR;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseOperation;

/// <summary>
/// </summary>
public class EditBaseOperation : BaseDomain<BaseOperationEntity>, IRequestHandler<BaseOperationEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseOperationEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}