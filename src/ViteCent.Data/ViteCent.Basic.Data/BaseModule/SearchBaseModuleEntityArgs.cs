#region

using MediatR;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
public class SearchBaseModuleEntityArgs : SearchArgs, IRequest<List<BaseModuleEntity>>
{
}