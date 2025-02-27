#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
///     SearchBaseRolePermissionArgs
/// </summary>
public class SearchBaseRolePermissionArgs : SearchArgs, IRequest<PageResult<BaseRolePermissionResult>>
{
}