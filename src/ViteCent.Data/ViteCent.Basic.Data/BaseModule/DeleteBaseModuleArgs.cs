#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
[Serializable]
public class DeleteBaseModuleArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}