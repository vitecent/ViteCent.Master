#region

using ViteCent.Basic.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain;

/// <summary>
/// </summary>
/// <summary>
/// </summary>
public class SimpleDomain : BaseDomain<SimpleEntity>, ISimpleDomain
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent";
}