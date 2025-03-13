#region

using MediatR;
using ViteCent.Basic.Entity.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModule;

/// <summary>
/// </summary>
public class EditBaseModule : BaseDomain<BaseModuleEntity>, IRequestHandler<BaseModuleEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseModuleEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}