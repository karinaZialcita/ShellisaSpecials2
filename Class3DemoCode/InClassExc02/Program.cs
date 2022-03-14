using System;

namespace InClassExc02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;

            string studentId;
            string labNumber;

            string labName;

            //Prompt user
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
            
            Console.WriteLine("Please enter your student id: ");
            studentId = Console.ReadLine();

            Console.WriteLine("Please enter the lab number: ");
            labNumber = Console.ReadLine();

            labName = labNumber + "_" + firstName.Substring(0, 1) + lastName.Substring(0, 2) + "_" + studentId.Substring(7,2);


            Console.WriteLine($"{labName}");
        }
    }
}
