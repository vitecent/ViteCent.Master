#region

using MediatR;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Data.BaseRole;

/// <summary>
/// </summary>
public class GetBaseRoleEntityArgs : IRequest<BaseRoleEntity>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}