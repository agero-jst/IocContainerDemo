using System;
using PackingEngine.Interfaces;

namespace PackingEngine.Implementations
{
    public class BagProvider : IBagProvider
    {
        public Bag ProvideBag()
        {
            Console.WriteLine("Providing new bag...");
            return new Bag();
        }
    }
}