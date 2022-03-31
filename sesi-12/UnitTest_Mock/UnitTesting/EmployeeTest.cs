using Moq;
using System;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;
using Xunit;

namespace UnitTesting
{
    public class EmployeeTest
    {
        #region Property
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion
        
        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p =>p.GetEmployeeById(1)).ReturnsAsync("Alex");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("Alex", result);
        }
        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "Alex",
                Destination = "Medan"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }

        
    }
}
