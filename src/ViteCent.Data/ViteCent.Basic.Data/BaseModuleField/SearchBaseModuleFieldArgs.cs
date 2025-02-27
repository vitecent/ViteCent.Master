#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
///     SearchBaseModuleFieldArgs
/// </summary>
public class SearchBaseModuleFieldArgs : SearchArgs, IRequest<PageResult<BaseModuleFieldResult>>
{
}