using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Demo.Inheritance
{
    // To use inheritance we must make constructor chaining
    internal class Child : Parent
    {
        public int Z {  get; set; }
        public Child (int _X, int _Y, int _Z) : base(_X, _Y)
        {
            Z = _Z;
        }
    }
}
