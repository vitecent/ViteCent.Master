#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
///     SearchEntityArgs
/// </summary>
public class SearchBaseRolePermissionEntityArgs : SearchArgs, IRequest<List<BaseRolePermissionEntity>>
{
}