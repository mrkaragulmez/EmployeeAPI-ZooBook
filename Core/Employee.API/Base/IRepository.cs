namespace Employee.Core.Base;

public interface IRepository<T>
{
    public IEnumerable<T> GetAll();
    // T GetById(object id);
    // void Insert(T obj);
    // void Update(T obj);
    // void Delete(object id);
    // void Save();
}