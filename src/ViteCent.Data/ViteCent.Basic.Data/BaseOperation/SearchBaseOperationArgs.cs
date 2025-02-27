#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
///     SearchBaseOperationArgs
/// </summary>
public class SearchBaseOperationArgs : SearchArgs, IRequest<PageResult<BaseOperationResult>>
{
}