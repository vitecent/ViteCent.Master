#region

using MediatR;
using ViteCent.Auth.Entity.BaseCompany;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseCompanyEntityArgs : IRequest<BaseCompanyEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}