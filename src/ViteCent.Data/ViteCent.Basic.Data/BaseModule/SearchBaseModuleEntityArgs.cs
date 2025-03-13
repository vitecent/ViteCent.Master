#region

using MediatR;
using ViteCent.Basic.Entity.BaseModule;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseModuleEntityArgs : SearchArgs, IRequest<List<BaseModuleEntity>>
{
}