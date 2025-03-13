#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
/// </summary>
[Serializable]
public class DeleteBaseCompanyEntityArgs : IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}