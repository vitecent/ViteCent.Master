#region

using MediatR;
using ViteCent.Basic.Entity.BaseModuleField;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseModuleFieldEntityArgs : IRequest<BaseModuleFieldEntity>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}