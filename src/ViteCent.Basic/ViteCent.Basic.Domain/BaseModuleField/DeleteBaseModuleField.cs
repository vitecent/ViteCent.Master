#region

using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Basic.Entity.BaseModuleField;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModuleField;

/// <summary>
/// </summary>
public class DeleteBaseModuleField : BaseDomain<BaseModuleFieldEntity>, IRequestHandler<DeleteBaseModuleFieldEntityArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(DeleteBaseModuleFieldEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.DeleteAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}