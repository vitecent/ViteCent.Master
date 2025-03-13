#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseResourceArgs : SearchArgs, IRequest<PageResult<BaseResourceResult>>
{
}