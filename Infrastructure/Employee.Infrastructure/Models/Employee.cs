using System;
using  Employee.Infrastructure.Base;

namespace Employee.Infrastructure.Models;

public class EmployeeDTO : EntityBase
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
}