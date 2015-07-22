using IocContainer;
using PackingEngine.Implementations;
using PackingEngine.Interfaces;

// ReSharper disable All

namespace TestRunner.Infrastructure
{
    public class DemoContainerConfig
    {
        public TrivialContainer ConfigureContainer()
        {
            var container = new TrivialContainer();
            container.Register<BoxBuilder>(delegate { return new BoxBuilder(); });
            container.Register<BoxLidCloser>(delegate { return new BoxLidCloser(); });
            container.Register<IBagProvider>(delegate { return new BagProvider(); });
            container.Register<IBagFiller>(delegate { return new BagFiller(container.Resolve<IBagProvider>()); });
            container.Register<IBoxPacker>(delegate { return new BoxPacker(container.Resolve<BoxBuilder>(), container.Resolve<BoxLidCloser>()); });
            container.Register<PackingRunner>(delegate { return new PackingRunner(container.Resolve<IBagFiller>(), container.Resolve<IBoxPacker>()); });
            return container;
        }
    }
}
