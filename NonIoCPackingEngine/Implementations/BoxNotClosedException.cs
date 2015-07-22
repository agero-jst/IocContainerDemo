using System;

namespace NonIoCPackingEngine.Implementations
{
    public class BoxNotClosedException : Exception
    {
        public BoxNotClosedException(string name)
            : base("Box " + name + " is not closed properly")
        {
        }
    }
}