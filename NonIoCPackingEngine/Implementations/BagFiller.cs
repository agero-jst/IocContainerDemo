using System;

namespace NonIoCPackingEngine.Implementations
{
    public class BagFiller
    {
        private readonly BagProvider _provider;

        public BagFiller()
        {
            _provider = new BagProvider();
        }

        public Bag FillBag()
        {
            var bag = _provider.ProvideBag();
            Console.WriteLine("Filling bag...");
            return bag;
        }
    }
}
