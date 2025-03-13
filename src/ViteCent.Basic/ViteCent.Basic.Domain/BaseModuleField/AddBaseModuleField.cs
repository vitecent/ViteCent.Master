#region

using MediatR;
using ViteCent.Basic.Entity.BaseModuleField;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModuleField;

/// <summary>
/// </summary>
public class AddBaseModuleField : BaseDomain<BaseModuleFieldEntity>, IRequestHandler<AddBaseModuleFieldEntity, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(AddBaseModuleFieldEntity request, CancellationToken cancellationToken)
    {
        return await base.AddAsync(request);
    }
}