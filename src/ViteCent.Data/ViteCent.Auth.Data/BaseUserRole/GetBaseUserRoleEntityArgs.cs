#region

using MediatR;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
/// </summary>
public class GetBaseUserRoleEntityArgs : IRequest<BaseUserRoleEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}