using OOP_Session2_Demo.Inheritance;
using OOP_Session2_Demo.Overriding;

namespace OOP_Session2_Demo
{
    internal class Program
    {
        #region Overloading
        public static int Sum (int X, int Y)
        {
            return X + Y;
        }
        //public static int Sum3Num(int X, int Y, int Z) // No overloading used
        //{
        //    return X + Y + Z;
        //}
        public static int Sum(int X, int Y, int Z) // No overloading used
        {
            return X + Y + Z;
        }
        public static double Sum(double X, double Y)
        {
            return X + Y;
        }
        public static double Sum(double X, int Y)
        {
            return X + Y;
        }
        public static double Sum(int X, double Y)
        {
            return X + Y;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Rana", 123);
            //Note.AddPerson(1, "Aya", 456);
            //Note.AddPerson(2, "Omar", 789);
            //Console.WriteLine(Note.GetNumber("Rana"));
            //Note.SetNumber("Rana", 222);
            //Console.WriteLine(Note.GetNumber("Rana"));
            //Note["Aya"] = 666; // Using Indexer as setter
            //Console.WriteLine(Note["Aya"]); // Using indexer as getter

            //string Name = "Rana";
            //Console.WriteLine(Name[0]); // using indexer for get
            //// cant use indexer for setting in strings
            #endregion
            #region Class
            Car C1;
            // Declare reference from type Car refereing to null
            // Can refer to an object from type Car or an object from another class inheriting from Car
            // CLR will allocate 4 Bytes for the reference at stack
            // CLR will allocate 0 B at heap
            //C1 = new Car(10, "BMW", 200);
            // new keyword
            // 1- Allocate Required Bytes for the object at heap 16 Bytes
            // 2- Initialize the allocated bytes of the object with the default value 
            // 3- Call user defined constructor if exist
            // 4- Assign the address ofthe allocated object at heap to the reference C1
            //Console.WriteLine(C1);
            //C1 = new Car(10, "BMW");
            //C1 = new Car(20);
            #endregion
            #region Inheritance
            //Child child = new Child(1, 2, 3);
            //Console.WriteLine(child);
            #endregion
            #region Relationships Between Classes

            #endregion
            #region Access Modifiers (private protected - protected - internal protected)

            #endregion
            #region Class vs. Struct

            #endregion
            #region Polymorphism
            // Polymorphism => متعدد الاشكال

            #region Overloading
            // امسن الميثود اعدل في الاستخدام بتاعها عشان اخليها اكثر ابداعية
            // اختلاف في عدد او نوع او ترتيب الباراميترز
            // works with struct
            #endregion
            #region Overriding
            // لازم يكون في انهيرتينس
            // هعدل في ميثود وارثها من حد تاني
            // doesnt work with struct

            //TypeA typeA = new TypeA(3);
            //typeA.A = 5;
            //typeA.MyFun01();
            //typeA.MyFun02();

            TypeB typeB = new TypeB(4,5);
            typeB.A = 10;
            typeB.B = 20;
            typeB.MyFun01();
            typeB.MyFun02();
            #endregion
            #endregion

        }
    }
}
