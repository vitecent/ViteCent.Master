#region

using MediatR;
using ViteCent.Basic.Entity.BaseResource;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseResourceEntityArgs : SearchArgs, IRequest<List<BaseResourceEntity>>
{
}