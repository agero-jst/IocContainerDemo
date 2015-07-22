using PackingEngine.Implementations;

namespace PackingEngine.Interfaces
{
    public interface IBoxPacker
    {
        Box PackBox(Bag bag);
    }
}