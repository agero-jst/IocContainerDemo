using System;
using System.Collections.Generic;
using System.Linq;

namespace PackingEngine.Implementations
{
    public class BoxLidCloser
    {
        private readonly ICollection<Box> _closedBoxes;

        public BoxLidCloser()
        {
            _closedBoxes = new List<Box>();
        }

        public Box CloseBox(Box box)
        {
            Console.WriteLine("Closing box...");
            AddBoxToQueue(box);
            return GetClosedBox(box.Identifier);
        }

        private Box GetClosedBox(Guid identifier)
        {
            Console.WriteLine("Getting closed box from supply...");
            return _closedBoxes.FirstOrDefault(box => box.Identifier == identifier);
        }

        private void AddBoxToQueue(Box box)
        {
            Console.WriteLine("Adding box to closing queue...");
            box.State = BoxState.Closed;
            _closedBoxes.Add(box);
        }
    }
}