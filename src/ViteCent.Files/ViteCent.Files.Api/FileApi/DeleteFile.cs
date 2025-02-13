/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using Microsoft.AspNetCore.Mvc;
using ViteCent.Core;
using ViteCent.Core.Data;
using ViteCent.Core.Web.Api;
using ViteCent.Files.Data.File;


#endregion

namespace ViteCent.Files.Api.FileApi;

/// <summary>
///     删除文件
/// </summary>
[ApiController]
[Route("File")]
public class DeleteFile : BaseApi<GetFileArgs, BaseResult>
{
    /// <summary>
    ///     删除文件
    /// </summary>
    /// <param name="args">参数</param>
    /// <returns>处理结果</returns>
    [HttpPost]
    [Route("DeleteFile")]
    public override async Task<BaseResult> InvokeAsync([FromBody] GetFileArgs args)
    {
        var root = $"{Environment.CurrentDirectory}/wwwroot";

        var exist = await new FileExist().InvokeAsync(args);

        if (!exist.IsSuccessStatusCode) return exist;

        BaseFile.Delete($"{root}/{args.Path}");

        return new BaseResult();
    }
}