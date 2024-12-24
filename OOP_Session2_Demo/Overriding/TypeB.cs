using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Demo.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB (int _A, int _B) : base(_A)
        {
            B = _B;
        }
        //overriding:
        // 1- using new keyword
        // masks the original function
        public new void MyFun01()
        {
            Console.WriteLine("I'm derived [Child]");
        }
        // 2- using virtual (must be used at parent)
        // alter the original function
        public override void MyFun02()
        {
            Console.WriteLine($"typeB is : A = {A}, B = {B}");
        }
    }
}
