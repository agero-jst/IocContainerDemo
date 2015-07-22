using Castle.MicroKernel.Registration;
using Castle.Windsor;
using PackingEngine;

namespace TestRunner.Infrastructure
{
    public static class CastleContainerConfig
    {
        public static IWindsorContainer ConfigureContainer()
        {
            var container = new WindsorContainer();
            container.Register(Classes.FromAssemblyContaining<IAmMarkerForPackingEngine>()
                     .InSameNamespaceAs<IAmMarkerForPackingEngine>(true)
                     .WithServiceDefaultInterfaces()
                     .LifestyleSingleton()); return container;
        }
    }
}
