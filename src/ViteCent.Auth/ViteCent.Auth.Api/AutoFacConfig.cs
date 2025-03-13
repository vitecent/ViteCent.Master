#region

using Autofac;
using System.Reflection;
using Module = Autofac.Module;

#endregion

namespace ViteCent.Auth.Api;

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
            var files = Directory.GetFiles(path, dll);

            foreach (var item in files)
            {
                var assembly = Assembly.LoadFrom(item);
                assemblies.Add(assembly);
            }
        }

        builder.RegisterAssemblyTypes(assemblies.ToArray())
            .Where(t => t.IsClass && !t.IsAbstract).AsImplementedInterfaces().InstancePerLifetimeScope();
    }
}