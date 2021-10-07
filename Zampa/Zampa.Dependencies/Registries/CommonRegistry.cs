using Autofac;
using Zampa.Core.Container;
using Zampa.Data.Container;

namespace Zampa.Dependencies.Registries
{
    public class CommonRegistry : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(CoreRegistry).Assembly)
                   .Where(t => t.Name.EndsWith("Provider"))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(DataRegistry).Assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces();
        }
    }
}
