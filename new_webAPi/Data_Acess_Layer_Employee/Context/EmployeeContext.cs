using Data_Acess_Layer_Employee.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer_Employee.Context
{
    public partial class EmployeeContext:DbContext
    {
        
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        //object of database entity
        public DbSet<Employee> employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("server=DESKTOP-403P7MH;Database=DBEmployee;Trusted_Connection=true;Integrated Security=True");
            }
        }
    }
}
