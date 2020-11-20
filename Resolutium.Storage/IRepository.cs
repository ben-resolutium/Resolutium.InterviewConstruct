namespace Resolutium.Storage
{
    public interface IRepository<T, U>
    {
        T Get(U key);
    }
}
