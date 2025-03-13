#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseOperationArgs : SearchArgs, IRequest<PageResult<BaseOperationResult>>
{
}