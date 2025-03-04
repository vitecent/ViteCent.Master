#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRole;

/// <summary>
/// </summary>
public class SearchBaseRoleEntityArgs : SearchArgs, IRequest<List<BaseRoleEntity>>
{
}