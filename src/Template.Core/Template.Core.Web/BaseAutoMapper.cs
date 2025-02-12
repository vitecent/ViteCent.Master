/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

#endregion

namespace Template.Core.Web;

/// <summary>
/// </summary>
public static class BaseAutoMapper
{
    /// <summary>
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="types"></param>
    public static void UseAutoMapper(this WebApplicationBuilder builder, params Type[] types)
    {
        builder.Services.AddAutoMapper(types);
    }
}