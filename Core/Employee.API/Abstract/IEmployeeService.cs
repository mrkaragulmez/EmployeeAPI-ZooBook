using Employee.Core.Base;
using Employee.Infrastructure.Models;

namespace Employee.Core.Abstract;

public interface IEmployeeService : IRepository<EmployeeDTO>
{
    public IEnumerable<EmployeeDTO> GetEmployees();
}