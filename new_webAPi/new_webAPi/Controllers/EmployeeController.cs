using Business_Logic_Layer_Employee;
using Business_Logic_Layer_Employee.BusinessInterface;
using Business_Logic_Layer_Employee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace new_webAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }
        //To get employee list from database.
        [HttpGet]
        [Route("getEmployee")]
        public List<EmployeeModel> geEmployees()
        {
            return _employee.getEmployee();
        }
        //To add data into database this method will call first when request from UI.
        [HttpPost]
        [Route("addEmployee")]
        public bool addEmployee([FromBody]EmployeeModel employeeModel)
        {
            bool flag = false;
            flag = _employee.addEmployee(employeeModel);
            return flag;
        }
    }
}
