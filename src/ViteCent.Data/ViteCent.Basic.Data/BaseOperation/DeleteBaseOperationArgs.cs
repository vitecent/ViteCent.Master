#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
/// </summary>
[Serializable]
public class DeleteBaseOperationArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}