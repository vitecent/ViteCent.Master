#region

using MediatR;
using ViteCent.Basic.Entity.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseResource;

/// <summary>
/// </summary>
public class EditBaseResource : BaseDomain<BaseResourceEntity>, IRequestHandler<BaseResourceEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseResourceEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}