﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer_Employee.Entitys
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public string phoneNumber { get; set; }
    }
}
