using Castle.Facilities.TypedFactory;
using Castle.Windsor;
using TestRunner.Installers;

namespace TestRunner.Infrastructure
{
    public static class CastleContainerConfig
    {
        public static IWindsorContainer ConfigureContainer()
        {
            var container = new WindsorContainer()
                .AddFacility<TypedFactoryFacility>()
                .Install(new PackingEngineInstaller());
            return container;
        }

    }
}
