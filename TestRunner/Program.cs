using System;
using PackingEngine.Implementations;
using PackingEngine.Interfaces;

namespace TestRunner
{
    // ReSharper disable once ClassNeverInstantiated.Global
    class Program
    {
        // ReSharper disable once UnusedMember.Local
        static PackingRunner BuildRunnerExplicitly()
        {
            var provider = new BagProvider();
            var builder = new BoxBuilder();
            var closer = new BoxLidCloser();
            IBagFiller bagPacker = new BagFiller(provider);
            IBoxPacker boxPacker = new BoxPacker(builder, closer);
            var runner = new PackingRunner(bagPacker, boxPacker);
            return runner;
        }

        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            #region Containers
            //var container = new Infrastructure.UnityContainerConfig().ConfigureContainer();
            //var container = CastleContainerConfig.ConfigureContainer();
            //var container = new DemoContainerConfig().ConfigureContainer();

            //var runner = container.Resolve<PackingRunner>();
            #endregion

            //var runner = BuildRunnerExplicitly();

            var runner = new NonIoCPackingEngine.Implementations.PackingRunner();

            var bundle = runner.PackBagInBox();

            var bag = bundle.Bag;
            var box = bundle.Box;

            Console.WriteLine("Done." + Environment.NewLine);
            Console.WriteLine("Bag created as " + bag.Name);
            Console.WriteLine("Box created as " + box.Name + " (containing bag " + box.Bag.Name + ")");

        }
    }
}
