using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using PackingEngine;

namespace TestRunner.Installers
{
    public class PackingEngineInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<IAmMarkerForPackingEngine>()
                .InSameNamespaceAs<IAmMarkerForPackingEngine>(true)
                .WithServiceDefaultInterfaces()
                .LifestyleSingleton());

        }
    }
}