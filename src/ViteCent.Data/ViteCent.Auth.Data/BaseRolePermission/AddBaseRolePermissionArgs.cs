#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
/// </summary>
public class AddBaseRolePermissionArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string OperationId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ResourceId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string RoleId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public int Status { get; set; }
}