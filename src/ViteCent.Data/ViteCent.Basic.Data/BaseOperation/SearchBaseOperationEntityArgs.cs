#region

using MediatR;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
///     SearchEntityArgs
/// </summary>
public class SearchBaseOperationEntityArgs : SearchArgs, IRequest<List<BaseOperationEntity>>
{
}