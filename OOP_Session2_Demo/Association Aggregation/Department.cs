using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Demo.Association_Aggregation
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[]? Employees { get; set; }
        public Department(string _Name)
        {
            Name = _Name;
        }
        public Department (string _Name, Employee[] _Employees)
        {
            Name = _Name;
            Employees = _Employees;
        }
    }
}
