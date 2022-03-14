using Class5Demo.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericsDemoCode.Entities
{
    class CompareEmployeesbyYearsWorked : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            return e1.YearsWorked.CompareTo(e2.YearsWorked);
        }
    }
}
