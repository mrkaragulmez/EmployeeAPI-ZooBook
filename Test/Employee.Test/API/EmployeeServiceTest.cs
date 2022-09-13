using Xunit;
using Employee.Core.Abstract;
using Employee.Infrastructure.Models;
using System.Collections.Generic;
using Employee.Core.Concrete;

namespace Employee.Test.API;

public class EmployeeServiceTest
{
    [Fact]
    public void GetEmployees_Returns_List_Of_Employee()
    {
        EmployeeService service = new ();
        var data = service.GetEmployees();
        Assert.NotNull(data);
        Assert.IsType<List<EmployeeDTO>>(data);
    }
}