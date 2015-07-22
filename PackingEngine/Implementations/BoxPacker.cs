using System;
using PackingEngine.Interfaces;

namespace PackingEngine.Implementations
{
    public class BoxPacker : IBoxPacker
    {
        private readonly BoxBuilder _builder;
        private readonly BoxLidCloser _closer;

        public BoxPacker(BoxBuilder builder, BoxLidCloser closer)
        {
            _builder = builder;
            _closer = closer;
        }

        public Box PackBox(Bag bag)
        {
            Console.WriteLine("Getting box...");
            var box = _builder.BuildBox();
            Console.WriteLine("Putting bag in box...");
            box.Bag = bag;
            box = _closer.CloseBox(box);
            if (box.State != BoxState.Closed)
            {
                throw new BoxNotClosedException(box.Name);
            }
            Console.WriteLine("Returning finished box...");
            return new Box(bag);
        }
    }
}
