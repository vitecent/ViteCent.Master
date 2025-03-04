#region

using MediatR;
using ViteCent.Basic.Entity;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
/// </summary>
public class GetBaseModuleFieldEntityArgs : IRequest<BaseModuleFieldEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}