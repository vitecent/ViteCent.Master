#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
///     AddBaseRolePermissionArgs
/// </summary>
public class AddBaseRolePermissionArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    ///     公司标识
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    ///     模块标识
    /// </summary>
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    ///     操作标识
    /// </summary>
    public string OperationId { get; set; } = string.Empty;

    /// <summary>
    ///     资源标识
    /// </summary>
    public string ResourceId { get; set; } = string.Empty;

    /// <summary>
    ///     角色标识
    /// </summary>
    public string RoleId { get; set; } = string.Empty;
}