using Microsoft.Practices.Unity;
using PackingEngine.Implementations;
using PackingEngine.Interfaces;

namespace TestRunner.Infrastructure
{
    public class UnityContainerConfig
    {
        public UnityContainer ConfigureContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IBagFiller, BagFiller>();
            container.RegisterType<IBoxPacker, BoxPacker>();
            container.RegisterInstance(new PackingRunner(container.Resolve<IBagFiller>(), container.Resolve<IBoxPacker>()));
            return container;
        }
    }
}
