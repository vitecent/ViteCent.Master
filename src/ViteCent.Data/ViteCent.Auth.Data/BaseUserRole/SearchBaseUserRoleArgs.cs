#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
/// </summary>
public class SearchBaseUserRoleArgs : SearchArgs, IRequest<PageResult<BaseUserRoleResult>>
{
}