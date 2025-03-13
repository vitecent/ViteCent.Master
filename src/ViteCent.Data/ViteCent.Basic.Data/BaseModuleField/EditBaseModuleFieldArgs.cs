namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
/// </summary>
[Serializable]
public class EditBaseModuleFieldArgs : AddBaseModuleFieldArgs
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}