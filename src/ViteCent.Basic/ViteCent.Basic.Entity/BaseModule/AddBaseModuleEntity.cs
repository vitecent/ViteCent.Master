#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Entity.BaseModule;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_module")]
public class AddBaseModuleEntity : BaseModuleEntity
{

}