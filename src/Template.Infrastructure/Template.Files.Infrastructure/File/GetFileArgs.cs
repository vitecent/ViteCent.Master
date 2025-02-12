/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Template.Core.Data;

#endregion

namespace Template.Files.Infrastructure.File;

/// <summary>
/// </summary>
public class GetFileArgs : BaseArgs
{
    /// <summary>
    ///     文件路径
    /// </summary>
    public string Path { get; set; } = default!;
}