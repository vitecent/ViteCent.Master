#region

using MediatR;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
/// </summary>
public class GetBaseRolePermissionEntityArgs : IRequest<BaseRolePermissionEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}