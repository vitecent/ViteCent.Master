#region

using Autofac;
using MediatR;
using System.Reflection;
using Module = Autofac.Module;

#endregion

namespace ViteCent.Basic.Api;

/// <summary>
///     AutoFacConfig 类用于配置 Autofac 依赖注入容器。
/// </summary>
public class AutoFacConfig : Module
{
    /// <summary>
    ///     重写 Load 方法以注册依赖项。
    /// </summary>
    /// <param name="builder">用于注册依赖项的 ContainerBuilder 对象。</param>
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        // 注册 MediatR 的核心服务
        builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

        var path = AppDomain.CurrentDomain.BaseDirectory;

        var assemblies = new List<Assembly>();

        var dlls = new List<string>() { "*Application.dll", "*Domain.dll" };

        foreach (var dll in dlls)
        {
            // 获取所有DLL文件
            var files = Directory.GetFiles(path, dll);

            foreach (var item in files)
            {
                // 加载程序集
                var assembly = Assembly.LoadFrom(item);
                assemblies.Add(assembly);
            }
        }

        // 注册程序集中的类型
        builder.RegisterAssemblyTypes(assemblies.ToArray())
            .Where(t => t.IsClass && !t.IsAbstract) // 仅注册非抽象类
            .AsImplementedInterfaces() // 注册其实现的接口
            .InstancePerLifetimeScope(); // 设置生命周期
    }
}