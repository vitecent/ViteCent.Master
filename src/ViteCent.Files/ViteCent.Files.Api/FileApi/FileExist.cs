/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using Microsoft.AspNetCore.Mvc;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Files.Data.File;


#endregion

namespace ViteCent.Files.Api.FileApi;

/// <summary>
///     文件是否存在
/// </summary>
[ApiController]
[Route("File")]
public class FileExist : BaseApi<GetFileArgs, BaseResult>
{
    /// <summary>
    ///     文件是否存在
    /// </summary>
    /// <param name="args">参数</param>
    /// <returns>处理结果</returns>
    [HttpPost]
    [Route("FileExist")]
    public override async Task<BaseResult> InvokeAsync([FromBody] GetFileArgs args)
    {
        return await Task.Run(() =>
        {
            var root = $"{Environment.CurrentDirectory}/wwwroot";

            if (System.IO.File.Exists($"{root}/{args.Path}")) return new BaseResult();

            return new BaseResult(404, $"文件{args.Path}不存在");
        });
    }
}