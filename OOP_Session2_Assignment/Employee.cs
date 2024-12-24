using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Assignment
{
    internal class Employee
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public Privileges SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Sex { get; set; }
        public Employee(int _Id, string _Name, Privileges _SecurityLevel, double _Salary, HiringDate _HireDate, Gender _Sex)
        {
            Id = _Id;
            Name = _Name;
            SecurityLevel = _SecurityLevel;
            Salary = _Salary;
            HireDate = _HireDate;
            Sex = _Sex;
        }
        public override string ToString()
        {
            return String.Format(
                "Id: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
                Id, Name, SecurityLevel, Salary, HireDate, Sex
            );
        }

    }
}
