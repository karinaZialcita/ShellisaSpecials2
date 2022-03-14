using System;

namespace StringDemo
{
    class Program
    {
        //class names are the only ones that should have a capital initial
        //if its a constant it should all be caps
        static void Main(string[] args)
        {

            //here are some variable we need 
            string firstName;
            string lastName;
            string domainName;

            string emailAddress;

            //Prompt user
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            
            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
            
            Console.WriteLine("Please enter your domain name: ");
            domainName = Console.ReadLine();


            //generate the emial address in the form of flname@domainname
            emailAddress = firstName.Substring(0, 1) + lastName + "@" + domainName;

            Console.WriteLine($"Email Address: {emailAddress}");

            //decrement for loop // printing it backwards
            for (int i = (emailAddress.Length - 1); i > 0; i-- )
            {
                Console.Write(emailAddress[i]);
                if (i == 1)
                {
                    Console.Write("\n");
                }
            }


            String oneWord = "word";
            String twoWord = "word";

            if( oneWord == twoWord)
            {
                Console.WriteLine("same!");
            }

            //checks if something contains the given
            if (twoWord.Contains("or"))
            {
                Console.WriteLine("We found matching contents!");
            } else
            {
                Console.WriteLine("We couldnt find any matching content");
            }


        }
    }
}
