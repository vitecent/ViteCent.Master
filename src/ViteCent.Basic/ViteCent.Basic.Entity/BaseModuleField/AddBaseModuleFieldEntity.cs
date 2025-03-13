#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Entity.BaseModuleField;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_module_field")]
public class AddBaseModuleFieldEntity : BaseModuleFieldEntity
{

}