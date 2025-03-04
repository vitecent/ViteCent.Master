#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
/// </summary>
public class SearchBaseUserRoleEntityArgs : SearchArgs, IRequest<List<BaseUserRoleEntity>>
{
}