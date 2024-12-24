using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Assignment
{
    internal class HiringDate
    {
        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HiringDate (int _Day, int _Month, int _Year)
        {
            if (IsValidDate(_Day, _Month, _Year))
            {
                Day = _Day;
                Month = _Month;
                Year = _Year;
            }
            else
            {
                Console.WriteLine("Invalid Date Format!!");
            }
            
        }
        private bool IsValidDate (int _Day, int _Month, int _Year)
        {
            if (_Month > 0 && _Month < 13 && _Year > 0)
            {
                if (_Day > 0 && _Day <= DateTime.DaysInMonth(_Year, _Month))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
