using System;

namespace NonIoCPackingEngine.Implementations
{
    public class BagProvider
    {
        public Bag ProvideBag()
        {
            Console.WriteLine("Providing new bag...");
            return new Bag();
        }
    }
}