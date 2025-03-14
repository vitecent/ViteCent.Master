#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseModuleFieldArgs : SearchArgs, IRequest<PageResult<BaseModuleFieldResult>>
{
}