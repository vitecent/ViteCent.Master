#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Service.Infrastructure.Simple;

/// <summary>
/// </summary>
public class SimpleArgs : SearchArgs, IRequest<PageResult<SimpleResult>>
{
}