using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using static System.Console;

namespace Class5Demo.Entities
{
    class Employee : Person
    {
        private string _employeeNumber;
        private EmployeeType _type = EmployeeType.Operational;
        private int _yearsWorked;
        public int YearsWorked { get { return _yearsWorked; } set { _yearsWorked = value; } }
        public EmployeeType empType { get { return _type; } set { _type = value; } }
        public string EmployeeNumber { get { return _employeeNumber; } set { _employeeNumber = value; } }

        //Constructors
        public Employee(string newName, int newYearsWorked, EmployeeType newType, string newEmployeeNumber): base(newName)
        {
            //Pass in the years
            _yearsWorked = newYearsWorked;
            _type = newType;
            _employeeNumber = newEmployeeNumber;
        }

        //Overloaded Operators
        public static int operator +(Employee e1, Employee e2)
        {
            return (e1.YearsWorked + e2.YearsWorked);
        }

        public static bool operator<(Employee e1, Employee e2)
        {
            return ((int)e1.empType < (int)e2.empType);
        }
        public static bool operator >(Employee e1, Employee e2)
        {
            return ((int)e1.empType > (int)e2.empType);
        }
        public static bool operator ==(Employee e1, Employee e2)
        {
            return (e1.EmployeeNumber == e2.EmployeeNumber &&
                e1.Name == e2.Name &&
                e1.empType == e1.empType) ? true : false;
        }

        //Check if the employees are not equal?

        public static bool operator !=(Employee e1, Employee e2)
        {

            //AND && OR || We want to check if any of them are different, not if all of them are different.
            return (e1.EmployeeNumber !=                  e2.EmployeeNumber ||
                    e1.Name != e2.Name ||
                e1.empType != e1.empType) ? true : false;
        }


        public void Work() => WriteLine($"{_name} is working.");

    }
}
