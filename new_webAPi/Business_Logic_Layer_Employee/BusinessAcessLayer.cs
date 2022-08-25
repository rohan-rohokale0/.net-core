using AutoMapper;
using Business_Logic_Layer_Employee.BusinessInterface;
using Business_Logic_Layer_Employee.Models;
using Data_Acess_Layer_Employee;
using Data_Acess_Layer_Employee.Context;
using Data_Acess_Layer_Employee.Entitys;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Business_Logic_Layer_Employee
{

    public class BusinessAcessLayer : IEmployee
    {
        
        private Mapper _employeeMapper;
        EmployeeContext _employeeContext;
        public BusinessAcessLayer(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
            var _configPerson = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeModel>().ReverseMap());

            _employeeMapper = new Mapper(_configPerson);
        }
        public List<EmployeeModel> getEmployee()
        {
            List<Employee> lstEmp = new List<Employee>();
            DataAcessLayer _DAL = new DataAcessLayer(_employeeContext);
            lstEmp = _DAL.getEmployees();
            List<EmployeeModel> lstEmployee = _employeeMapper.Map<List<Employee>, List<EmployeeModel>>(lstEmp);
            return lstEmployee;
        }
        public bool addEmployee(EmployeeModel employee)
        {
            bool flag = false;
            DataAcessLayer _DAL = new DataAcessLayer(_employeeContext);
            Employee emp = _employeeMapper.Map<EmployeeModel, Employee>(employee);
            flag = _DAL.addEmployee(emp);
            return flag;
        }
    }
}
