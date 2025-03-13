#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Entity.BaseOperation;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_operation")]
public class AddBaseOperationEntity : BaseOperationEntity
{

}