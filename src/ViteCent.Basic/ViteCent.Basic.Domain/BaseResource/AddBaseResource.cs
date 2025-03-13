#region

using MediatR;
using ViteCent.Basic.Entity.BaseResource;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseResource;

/// <summary>
/// </summary>
public class AddBaseResource : BaseDomain<BaseResourceEntity>, IRequestHandler<AddBaseResourceEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(AddBaseResourceEntity request, CancellationToken cancellationToken)
    {
        return await base.AddAsync(request);
    }
}