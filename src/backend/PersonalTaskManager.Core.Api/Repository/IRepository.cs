public interface IRepository<T> where T : BaseEntity
{
    IReadOnlyCollection<T> GetAll();
    T? Get(string id);
    void Add(T entity);
    void Patch(T entity, string id);
    void Delete(string id);
}