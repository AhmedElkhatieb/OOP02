using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2_Demo
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        long[] numbers;
        int size;
        #endregion
        #region Properties
        public int Size
        {
            get
            {
                return size;
            }
        }
        #endregion
        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion
        #region Methods
        public void AddPerson(int Position, string Name, long Number)
        {
            if (names != null && numbers != null)
            {
                if (Position >= 0 && Position < size)
                {
                    names[Position] = Name;
                    numbers[Position] = Number;
                }
            }
        }
        #endregion
        #region Encapsulation
        #region Getter/Setter
        // Getter
        public long GetNumber (string Name)
        {
            if (names != null && numbers != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == Name)
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }
        // Setter
        public void SetNumber (string Name, long NewNumber)
        {
            if (names != null && numbers != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == Name)
                    {
                        numbers[i] = NewNumber;
                    }
                }
            }
        }

        // Indexer
        // Is a special property
        // Named always with this keyword
        // can take parameters
        public long this[string Name]
        {
            get
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == Name)
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == Name)
                        {
                            numbers[i] = value;
                        }
                    }
                }
            }
        }
        #endregion
        #endregion
    }
}
