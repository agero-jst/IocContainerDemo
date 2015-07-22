using System;

namespace NonIoCPackingEngine.Implementations
{

    public class BoxPacker
    {
        private readonly BoxBuilder _builder;
        private readonly BoxLidCloser _closer;

        public BoxPacker()
        {
            _builder = new BoxBuilder();
            _closer = new BoxLidCloser();
        }

        public Box PackBox(Bag bag)
        {
            Console.WriteLine("Asking for box...");
            var box = _builder.BuildBox();
            PutBagInBox(bag, box);
            box = _closer.CloseBox(box);
            if (box.State != BoxState.Closed)
            {
                throw new BoxNotClosedException(box.Name);
            }
            Console.WriteLine("Returning finished box...");
            return new Box(bag);
        }

        private static void PutBagInBox(Bag bag, Box box)
        {
            Console.WriteLine("Putting bag in box...");
            box.Bag = bag;
        }
    }
}
