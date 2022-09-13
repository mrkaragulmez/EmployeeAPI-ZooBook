namespace Employee.Core.Base;
//This generic pattern should use for more than 1 table ORM design
public class Repository<T> : IRepository<T> where T : class
{
    public IEnumerable<T> GetAll()
    {
        return new List<T>();
    }
}