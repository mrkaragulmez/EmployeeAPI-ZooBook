using Employee.Core.Abstract;
using Employee.Core.Base;
using Employee.Infrastructure.Models;

namespace Employee.Core.Concrete;

public class EmployeeService : IEmployeeService
{
    public IEnumerable<EmployeeDTO> GetAll() => new List<EmployeeDTO>();
    

    public IEnumerable<EmployeeDTO> GetEmployees()
    {
        List<EmployeeDTO> model = new ();
        try
        {
            model = new List<EmployeeDTO>
            {
                new EmployeeDTO
                {
                    Id = 1,
                    FirstName = "Omer",
                    MiddleName = "Faruk",
                    LastName = "Karagulmez"
                }
            };
        }
        catch (System.Exception ex)
        {
            //log exception
        }
        return model;
    }
}