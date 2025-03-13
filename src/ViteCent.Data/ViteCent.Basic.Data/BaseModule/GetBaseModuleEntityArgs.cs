#region

using MediatR;
using ViteCent.Basic.Entity.BaseModule;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseModuleEntityArgs : IRequest<BaseModuleEntity>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}