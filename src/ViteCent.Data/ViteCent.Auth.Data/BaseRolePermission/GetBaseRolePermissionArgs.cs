#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
///     GetBaseRolePermissionArgs
/// </summary>
public class GetBaseRolePermissionArgs : BaseArgs, IRequest<DataResult<BaseRolePermissionResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}