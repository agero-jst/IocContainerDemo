using System;
using PackingEngine.Interfaces;

namespace PackingEngine.Implementations
{
    public class BagFiller : IBagFiller
    {
        private readonly Bag _bag;

        public BagFiller(IBagProvider provider)
        {
            _bag = provider.ProvideBag();
        }

        public Bag FillBag()
        {
            Console.WriteLine("Filling bag...");
            return _bag;
        }
    }
}
