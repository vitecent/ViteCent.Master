namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
///     EditBaseUserDepartmentArgs
/// </summary>
public class EditBaseUserDepartmentArgs : AddBaseUserDepartmentArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}