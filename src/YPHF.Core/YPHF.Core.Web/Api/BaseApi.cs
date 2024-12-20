﻿/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Mvc;
using YPHF.Core.Data;

namespace YPHF.Core.Web.Api
{
    /// <summary>
    /// </summary>
    /// <typeparam name="Args"></typeparam>
    /// <typeparam name="Result"></typeparam>
    public abstract class BaseApi<Args, Result> : ControllerBase
        where Args : BaseArgs
        where Result : BaseResult
    {
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public abstract Task<Result> InvokeAsync(Args args);
    }
}