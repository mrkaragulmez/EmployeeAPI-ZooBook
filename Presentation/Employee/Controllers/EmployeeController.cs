using Employee.Core.Abstract;
using Employee.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;
    private readonly IEmployeeService _employeeService;

    public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
    {
        _logger = logger;
        _employeeService = employeeService;
    }

    [ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
    [HttpGet]
    public IEnumerable<EmployeeDTO> Get() => _employeeService.GetEmployees();
    
}
