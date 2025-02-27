#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUser;

/// <summary>
///     SearchEntityArgs
/// </summary>
public class SearchBaseUserEntityArgs : SearchArgs, IRequest<List<BaseUserEntity>>
{
}