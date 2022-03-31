using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;
using UnitTest_Mock.Controllers;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeeById(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}