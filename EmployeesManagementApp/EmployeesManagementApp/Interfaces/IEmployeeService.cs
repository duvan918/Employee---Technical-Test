using EmployeesManagementApp.Models;

namespace EmployeesManagementApp.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee?> GetEmployeeByIdAsync(int id);
    }
}
