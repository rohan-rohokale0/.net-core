using Data_Acess_Layer_Employee.Context;
using Data_Acess_Layer_Employee.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Acess_Layer_Employee
{
    public class DataAcessLayer
    {
        EmployeeContext _employeeContext;
        public DataAcessLayer(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<Employee> getEmployees()
        {
            return _employeeContext.employee.ToList();
        }
        public bool addEmployee(Employee employee)
        {
            bool flag = false;
            try
            {
                _employeeContext.employee.Add(employee);
                _employeeContext.SaveChanges();
              //If data saved successfully it will return true(flag)
                flag = true;

            }
            catch (Exception)
            {
                //If data not saved successfully it will return true(flag)
                flag = false;
                throw;
            }
            return flag;
        }

    }
}
