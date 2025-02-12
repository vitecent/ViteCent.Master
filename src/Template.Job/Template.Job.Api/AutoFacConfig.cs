/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Autofac;
using Template.Job.Application;

#endregion

namespace Template.Job.Api;

/// <summary>
/// </summary>
public class AutoFacConfig : Module
{
    /// <summary>
    /// </summary>
    /// <param name="builder"></param>
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);
        builder.RegisterType(typeof(HomeApplication)).As(typeof(IHomeApplication));
    }
}