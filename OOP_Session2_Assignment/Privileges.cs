using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Assignment
{
    internal enum Privileges
    {
        None = 0, Guest = 1, Developer = 2, Secretary = 4, DBA = 8,
        SecurityOfficer = Guest | Developer | Secretary | DBA
    }
}
