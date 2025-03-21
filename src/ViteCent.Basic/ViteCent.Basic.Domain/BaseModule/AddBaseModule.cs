#region

using MediatR;
using ViteCent.Basic.Entity.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModule;

/// <summary>
/// </summary>
public class AddBaseModule : BaseDomain<BaseModuleEntity>, IRequestHandler<AddBaseModuleEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(AddBaseModuleEntity request, CancellationToken cancellationToken)
    {
        return await base.AddAsync(request);
    }
}