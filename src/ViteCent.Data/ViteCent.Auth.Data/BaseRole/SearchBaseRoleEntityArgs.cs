#region

using MediatR;
using ViteCent.Auth.Entity.BaseRole;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRole;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseRoleEntityArgs : SearchArgs, IRequest<List<BaseRoleEntity>>
{
}