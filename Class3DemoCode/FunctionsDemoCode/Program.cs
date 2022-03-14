using System;

namespace FunctionsDemoCode
{
    class Program
    {
        const double TAX = 0.14;
        //this function will calculate and display the tax
        static double addTax(ref double cost)
        {
            //when the code in here runs
            cost += (cost *= TAX);
            return cost;

            //all the changes are lost.. unless!!
        }
        static int calculateArea(int length, int width)
        {
            return length* width;
        }
        static string generateNamingConvention(string assignmentName, string firstName, string lastName, string studentNumber)
        {
            string convention = assignmentName + "_" + firstName.Substring(0, 0).ToUpper() + lastName.Substring(0, 1).ToUpper() + lastName.Substring(0, 1).ToLower() + "_" + assignmentName.Substring(assignmentName.Length - 2, assignmentName.Length);
            return convention;
        }
                                                      //params has to be at the end
        static string[] generateEmail(string domainName, params string[] names)
        {
            //array to store the email Addresses
            string[] emailAddresses = new string[names.Length];
           for(int n = 0; n < names.Length; n++)
            {
                  
                string[] firstAndLast = names[n].Split(" ");
                /*"Sam Hill" -> "Sam"[0] "Hill"[1]; thats how split works*/
                emailAddresses[n] = (firstAndLast[0].Substring(0, 1) + firstAndLast[1] + "@" + domainName).ToLower();
            }
            return emailAddresses;
        }
        static void Main(string[] args)
        {
            foreach (string newEmailAddresses in generateEmail("students.vcc.ca", "oksana astankova", "eve polastri"))
            {
                Console.WriteLine(newEmailAddresses);
            }



            /*double price = 5.00;

            addTax(ref price);
            Console.WriteLine($"THe full price with tax is: {addTax(ref price)}");*/

            /*int squareLength = 5;
            int squareWidth = 3;

            int squareArea = calculateArea(squareLength, squareWidth);
            Console.Write("The area is " + squareArea);*/

/*
            string assignmentName;
            string firstName;
            string lastName;
            string studentNumber;

            Console.WriteLine("Please enter assignment name: ");
            assignmentName = Console.ReadLine();

            Console.WriteLine("Please enter assignment name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter assignment name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter assignment name: ");
            studentNumber = Console.ReadLine();

            Console.WriteLine($"You should name you solution, project and Program.cs files as follows: {generateNamingConvention(assignmentName, firstName, lastName, studentNumber)}");*/
        }
    }
}
