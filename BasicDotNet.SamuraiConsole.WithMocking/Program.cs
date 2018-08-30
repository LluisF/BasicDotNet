namespace BasicDotNet.SamuraiConsole.WithMocking
{
    using Autofac;
    using SamuraiConsole.WithMocking.Entities;

    class Program
    {
        static void Main()
        {
            var iocContainerBuilder = new ContainerBuilder();
            iocContainerBuilder.RegisterType<Samurai>()
                .InstancePerLifetimeScope();
            iocContainerBuilder.RegisterType<Sword>()
                .As<IWeapon>()
                .InstancePerLifetimeScope();

            var iocContainer = iocContainerBuilder.Build();
            var sam = iocContainer.Resolve<Samurai>();
        }
    }
}
