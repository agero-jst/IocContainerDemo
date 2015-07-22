using System;
using System.Collections.Generic;
using System.Linq;

namespace NonIoCPackingEngine.Implementations
{
    public class BoxBuilder
    {
        private readonly ICollection<Box> _boxSupply;

        public BoxBuilder()
        {
            _boxSupply = new List<Box> { new Box() };
        }


        public Box BuildBox()
        {
            Console.WriteLine("Building box...");
            return _boxSupply.First() ?? new Box();
        }
    }
}