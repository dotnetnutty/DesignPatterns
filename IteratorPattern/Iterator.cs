namespace IteratorCompositePatterns
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}