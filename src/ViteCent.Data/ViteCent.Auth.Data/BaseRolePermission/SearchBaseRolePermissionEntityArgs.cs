#region

using MediatR;
using ViteCent.Auth.Entity.BaseRolePermission;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseRolePermissionEntityArgs : SearchArgs, IRequest<List<BaseRolePermissionEntity>>
{
}