using System;

namespace NonIoCPackingEngine.Implementations
{ // ReSharper disable All

    public class PackingRunner
    {
        private BagFiller _bagPacker;
        private BoxPacker _boxPacker;

        public PackingRunner()
        {
            _bagPacker = new BagFiller();
            _boxPacker = new BoxPacker();
        }

        public Bundle PackBagInBox()
        {
            Console.WriteLine("Asking to get bag for box...");
            var bag = _bagPacker.FillBag();
            Console.WriteLine("Asking to pack bag in box...");
            var box = _boxPacker.PackBox(bag);
            return new Bundle { Bag = bag, Box = box };
        }
    }
}