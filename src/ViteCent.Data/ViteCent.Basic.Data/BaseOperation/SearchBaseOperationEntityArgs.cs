#region

using MediatR;
using ViteCent.Basic.Entity.BaseOperation;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseOperationEntityArgs : SearchArgs, IRequest<List<BaseOperationEntity>>
{
}