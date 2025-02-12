/*
 *
 * 版权所有 ：ViteCent
 * 作   者 : ViteCent
 *
 */

#region

using ViteCent.Core.Data;

#endregion

namespace ViteCent.Files.Infrastructure.File;

/// <summary>
/// </summary>
public class GetFileArgs : BaseArgs
{
    /// <summary>
    ///     文件路径
    /// </summary>
    public string Path { get; set; } = default!;
}