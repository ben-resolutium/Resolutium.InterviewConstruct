namespace Resolutium.Identity
{
    public interface Identifiable<T>
    {
        T Key { get; }
    }
}