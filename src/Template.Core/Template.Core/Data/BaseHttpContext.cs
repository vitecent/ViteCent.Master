﻿/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

#endregion

namespace Template.Core.Data;

/// <summary>
/// </summary>
public class BaseHttpContext
{
    /// <summary>
    /// </summary>
    public static HttpContext Context
    {
        get
        {
            var factory = Services.BuildServiceProvider().GetService(typeof(IHttpContextAccessor));

            if (factory == null) return default!;

            var context = ((IHttpContextAccessor)factory).HttpContext ?? default!;

            return context ?? default!;
        }
    }

    /// <summary>
    /// </summary>
    public static IServiceCollection Services { get; set; } = default!;
}