public interface IRepository<T> where T : class
{
    IReadOnlyCollection<T> GetAll();
    T? Get(string id);
    void Add(T entity);
    void Delete(string id);
}