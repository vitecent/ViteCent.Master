#region

using MediatR;
using ViteCent.Basic.Entity;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
public class GetBaseModuleEntityArgs : IRequest<BaseModuleEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}