#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
public class SearchBaseModuleArgs : SearchArgs, IRequest<PageResult<BaseModuleResult>>
{
}