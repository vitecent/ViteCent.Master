#region

using Autofac;
using MediatR;
using System.Reflection;
using Module = Autofac.Module;

#endregion

namespace ViteCent.Basic.Api;

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