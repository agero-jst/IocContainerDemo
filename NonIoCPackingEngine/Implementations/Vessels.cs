using System;
using System.Linq;

namespace NonIoCPackingEngine.Implementations
{
    public abstract class UniqueVessel
    {
        public Guid Identifier { get; private set; }

        protected UniqueVessel()
        {
            Identifier = Guid.NewGuid();
        }

        // ReSharper disable once VirtualMemberNeverOverriden.Global - virtual due to testing
        public virtual string Name { get { return Identifier.LastFragment().Substring(0, 5); } }
    }

    public class Bag : UniqueVessel
    {
    }

    public class Box : UniqueVessel
    {
        public Bag Bag { get; set; }
        public BoxState State { get; set; }

        public Box(Bag bag = null)
        {
            State = BoxState.Unclosed;
            Bag = bag;
        }

    }

    public class Bundle
    {
        public Bag Bag { get; set; }
        public Box Box { get; set; }
    }

    public static class GuidExtensions
    {
        public static string LastFragment(this Guid guid)
        {
            return guid.ToString().Split('-').Last();
        }
    }

    public enum BoxState
    {
        Closed,
        Unclosed
    }
}
