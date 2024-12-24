using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        public void Test01 ()
        {
            TypeA obj = new TypeA ();
            ////obj.X = 10 // X is private
            ////obj.Y = 20 // Y is private
            //obj.Z = 30;
            // after inheritance:
            // X is inherited private
            // Y is inherited private
            // Z is inherited internal
        }
    }
}
