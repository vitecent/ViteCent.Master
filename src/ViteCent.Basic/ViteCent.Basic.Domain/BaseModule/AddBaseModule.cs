#region

using MediatR;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModule;

/// <summary>
///     AddBaseModule
/// </summary>
public class AddBaseModule : BaseDomain<BaseModuleEntity>, IRequestHandler<BaseModuleEntity, BaseResult>
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
    public async Task<BaseResult> Handle(BaseModuleEntity request, CancellationToken cancellationToken)
    {
        return await base.AddAsync(request);
    }
}