using Business_Logic_Layer_Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer_Employee.BusinessInterface
{
    public interface IEmployee
    {
        public List<EmployeeModel> getEmployee();
        public bool addEmployee(EmployeeModel employeeModel);
    }
}
