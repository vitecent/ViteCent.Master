#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.Simple;

/// <summary>
/// </summary>
public class SimpleArgs : SearchArgs, IRequest<PageResult<SimpleResult>>
{
}