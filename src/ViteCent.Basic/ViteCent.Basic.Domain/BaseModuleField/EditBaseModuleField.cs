#region

using MediatR;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModuleField;

/// <summary>
/// </summary>
public class EditBaseModuleField : BaseDomain<BaseModuleFieldEntity>, IRequestHandler<BaseModuleFieldEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(BaseModuleFieldEntity request, CancellationToken cancellationToken)
    {
        return await base.EditAsync(request);
    }
}