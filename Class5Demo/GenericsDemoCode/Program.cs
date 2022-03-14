using Class5Demo.Entities;
using GenericsDemoCode.Entities;
using System;
using System.Collections;
using System.Collections.Generic;


namespace GenericsDemoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Sam Hill", 7, EmployeeType.Managment, "1233342"));
            employees.Add(new Employee("Sailor Jerry", 10, EmployeeType.Operational,  "233342"));
            employees.Add(new Employee("Jack Daniels", 5, EmployeeType.Operational, "125643342"));
            employees.Add(new Employee("Captain Morgan", 7, EmployeeType.Operational, "32133342"));

            //Instntiate the Comparator
            IComparer<Employee> myYearsWorkedComparison = new CompareEmployeesbyYearsWorked();
            employees.Sort(myYearsWorkedComparison);

            foreach(Employee p in employees)
            {
                Console.WriteLine(p.Name + " - " + p.YearsWorked);
            }


        }
    }
}
