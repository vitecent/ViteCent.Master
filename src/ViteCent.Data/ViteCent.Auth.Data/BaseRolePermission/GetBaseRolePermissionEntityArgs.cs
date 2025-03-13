#region

using MediatR;
using ViteCent.Auth.Entity.BaseRolePermission;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseRolePermissionEntityArgs : IRequest<BaseRolePermissionEntity>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}