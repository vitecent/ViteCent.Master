#region

using MediatR;
using ViteCent.Auth.Entity.BaseUserRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseUserRoleEntityArgs : SearchArgs, IRequest<List<BaseUserRoleEntity>>
{
}