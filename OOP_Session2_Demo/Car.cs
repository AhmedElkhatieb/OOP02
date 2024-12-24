using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Demo
{
    internal class Car
    {
        #region Attributes
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Car ID = {Id}\nCar Model = {Model}\nCar Speed = {Speed}";
        }
        #endregion
        #region Constructor
        // if no user defined constructor exist, compiler will always generate parameterless constructor
        // if exists, parameterless will be removed

        // Constructor Chaining
        public Car(int Id, string Model, double Speed)
        {
            Console.WriteLine("Constructor 01");
            this.Id = Id;
            this.Model = Model;
            this.Speed = Speed;
        }
        public Car (int _Id, string _Model):this(_Id, _Model, 150)
        {
            Console.WriteLine("Constructor 02");
            //Id = _id;
            //Model = _model;
            //Speed = 150;
        }
        public Car (int _Id) : this(_Id, "Mercedes", 200)
        {
            Console.WriteLine("Constructor 03");
        }
        #endregion

    }
}
