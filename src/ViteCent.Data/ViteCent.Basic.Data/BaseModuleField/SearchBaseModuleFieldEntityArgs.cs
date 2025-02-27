#region

using MediatR;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
///     SearchEntityArgs
/// </summary>
public class SearchBaseModuleFieldEntityArgs : SearchArgs, IRequest<List<BaseModuleFieldEntity>>
{
}