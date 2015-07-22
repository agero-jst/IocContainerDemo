using System;
using PackingEngine.Interfaces;

namespace PackingEngine.Implementations
{ // ReSharper disable All

    public class PackingRunner
    {
        private IBagFiller _bagPacker;
        private IBoxPacker _boxPacker;

        public PackingRunner(IBagFiller bagPacker, IBoxPacker boxPacker)
        {
            _bagPacker = bagPacker;
            _boxPacker = boxPacker;
        }

        public Box PackBagInBox()
        {
            Console.WriteLine("Getting bag for box...");
            var bag = _bagPacker.FillBag();
            Console.WriteLine("Packing bag in box...");
            var box = _boxPacker.PackBox(bag);
            return box;
        }
    }
}