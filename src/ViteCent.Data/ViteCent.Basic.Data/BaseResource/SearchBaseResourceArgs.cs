#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
public class SearchBaseResourceArgs : SearchArgs, IRequest<PageResult<BaseResourceResult>>
{
}