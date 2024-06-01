using EmployeesManagementApp.Interfaces;

namespace EmployeesManagementApp.BusinessLogic
{
    public class EmployeeBusinessLogic : IEmployeeBusinessLogic
    {
        public int CalculateAnnualSalary(int monthlySalary)
        {
            return monthlySalary * 12;
        }
    }
}
