#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseRolePermissionArgs : BaseArgs, IRequest<DataResult<BaseRolePermissionResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}