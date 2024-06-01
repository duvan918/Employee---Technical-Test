using EmployeesManagementApp.BusinessLogic;
using Xunit;

namespace EmployeesManagementApp.Tests
{
    public class EmployeeBusinessLogicTests
    {
        [Fact]
        public void CalculateAnnualSalary_ShouldReturnCorrectValue()
        {
            // Arrange
            var businessLogic = new EmployeeBusinessLogic();
            int monthlySalary = 1000;
            int expectedAnnualSalary = 12000;

            // Act
            int actualAnnualSalary = businessLogic.CalculateAnnualSalary(monthlySalary);

            // Assert
            Assert.Equal(expectedAnnualSalary, actualAnnualSalary);
        }
    }
}
