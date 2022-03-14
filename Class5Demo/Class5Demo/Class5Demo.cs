using Class5Demo.Entities;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Class5Demo
{
    class Class5Demo
    {
        static void Main(string[] args)
        {
            //Put some people int he array
            Person[] peopleArr = new Person[3]
            {
                new Employee("Mathew", 15, EmployeeType.Administration, "543542354"),
                new Employee("Mark", 3, EmployeeType.Managment,"34234222"),
                new Employee("John", 5, EmployeeType.Operational, "543542354")
            };

            PeopleList employeeList = new PeopleList(peopleArr);

            foreach  (Person p in peopleArr)
            {
                Console.WriteLine(p.Name + " " + p.GetType());
            }

            Console.WriteLine($"Mathew plus Mark equals {(Employee)peopleArr[0] + (Employee)peopleArr[1]}");

            if ((Employee)peopleArr[0] > (Employee)peopleArr[1])
            {
                Console.WriteLine("Mathew is the greater employee.");
            }

            if ((Employee)peopleArr[0] == (Employee)peopleArr[2])
                Console.WriteLine("Houston, we have a problem.");
        }
    }
}
