#region

using MediatR;
using ViteCent.Auth.Entity.BaseUser;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUser;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseUserEntityArgs : SearchArgs, IRequest<List<BaseUserEntity>>
{
}