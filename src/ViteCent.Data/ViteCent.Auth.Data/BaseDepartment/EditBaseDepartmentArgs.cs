namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
///     EditBaseDepartmentArgs
/// </summary>
public class EditBaseDepartmentArgs : AddBaseDepartmentArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}