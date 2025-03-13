#region

using MediatR;
using ViteCent.Basic.Entity.BaseModuleField;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseModuleFieldEntityArgs : SearchArgs, IRequest<List<BaseModuleFieldEntity>>
{
}