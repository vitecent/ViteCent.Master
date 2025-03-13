namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
[Serializable]
public class EditBaseUserDepartmentArgs : AddBaseUserDepartmentArgs
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}