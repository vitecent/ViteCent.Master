﻿#region

using System.Security.Cryptography;
using System.Text;

#endregion

namespace Template.Core;

/// <summary>
///     Class FileExtensions.
/// </summary>
public class BaseFile
{
    /// <summary>
    ///     Copies the specified from.
    /// </summary>
    /// <param name="from">From.</param>
    /// <param name="to">To.</param>
    /// <returns>result</returns>
    public static bool Copy(string from, string to)
    {
        if (File.Exists(from) && from != to)
        {
            File.Copy(from, to, true);

            return true;
        }

        return false;
    }

    /// <summary>
    ///     Creates the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>result</returns>
    public static bool Create(string path)
    {
        var _path = path.Replace(@"\", @"/");
        var __path = Path.GetDirectoryName(path) ?? default!;

        if (!Directory.Exists(__path)) Directory.CreateDirectory(__path);

        if (!File.Exists(_path)) File.Create(_path).Close();

        return true;
    }

    /// <summary>
    ///     Cuts the specified from.
    /// </summary>
    /// <param name="from">From.</param>
    /// <param name="to">To.</param>
    /// <returns>result</returns>
    public static bool Cut(string from, string to)
    {
        if (Copy(from, to)) return Delete(from);

        return false;
    }

    /// <summary>
    ///     Deletes the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>result</returns>
    public static bool Delete(string path)
    {
        return Delete(path, 3);
    }

    /// <summary>
    ///     Deletes the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <param name="times">The times.</param>
    /// <returns>result</returns>
    public static bool Delete(string path, int times)
    {
        DeleteMethod(path, times);

        return !File.Exists(path);
    }

    /// <summary>
    ///     Gets the file byte.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>System.Byte[].</returns>
    public static byte[] GetFileByte(string path)
    {
        return GetFileStream(path).StreamToByte();
    }

    /// <summary>
    ///     Gets the file stream.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>Stream.</returns>
    public static Stream GetFileStream(string path)
    {
        return Open(path).StringToStream();
    }

    /// <summary>
    ///     Opens the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>System.String.</returns>
    public static string Open(string path)
    {
        return Open(path, Encoding.Default);
    }

    /// <summary>
    ///     Opens the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>System.String.</returns>
    public static string Open(string path, Encoding encoding)
    {
        if (File.Exists(path))
        {
            var sr = new StreamReader(path, encoding);

            return sr.ReadToEnd();
        }

        return default!;
    }

    /// <summary>
    ///     Writes the specified string.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <param name="path">The path.</param>
    /// <returns>result</returns>
    public static bool Write(string str, string path)
    {
        Create(path);
        using var sw = new StreamWriter(path);
        sw.Write(str);

        return true;
    }

    /// <summary>
    ///     Deletes the method.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <param name="times">The times.</param>
    private static void DeleteMethod(string path, int times)
    {
        if (!File.Exists(path)) throw new FileNotFoundException(path);

        File.SetAttributes(path, FileAttributes.Normal);
        var number = (int)Math.Ceiling(new FileInfo(path).Length / 512.0);
        var bytes = new byte[512];
        var rng = RandomNumberGenerator.Create();

        using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
        {
            for (var i = 0; i < times; i++)
            {
                fs.Position = 0;
                for (var j = 0; j < number; j++)
                {
                    rng.GetBytes(bytes);
                    fs.Write(bytes, 0, bytes.Length);
                }
            }

            fs.SetLength(0);
            fs.Close();
        }

        var time = DateTime.Now.AddYears(100);
        File.SetCreationTime(path, time);
        File.SetLastAccessTime(path, time);
        File.SetLastWriteTime(path, time);
        File.Delete(path);
    }
}