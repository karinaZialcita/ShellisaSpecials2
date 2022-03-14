using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an array
            int[] numbers = {5,4,3,1,2};

            //Blank Array , initialize a new array over the uninitialized address for "randomNumbers"
            int[] randomNumbers = new int[5] { 5, 4, 56, 34, 37 };

            //Blank Array to populate
            int[] newRandomNumbers = new int[10];


            //Array of Names
            string[] classNames = { "villanelle", "eve", "ellie", "aster", "dolores", "charlotte"};


            //object Random
            Random rand = new Random();

            //go through the entire array
            for (int i = 0; i < newRandomNumbers.Length; i++)
            {
                
                newRandomNumbers[i] = rand.Next(1, 100);
                /*newRandomNumbers[i] %= 5; //random numbers using the remainder of 5*/
            }

            int counter = 0;
            foreach (int r in newRandomNumbers)
            {
                //this will run for every r in newRandomNumbers
                Console.WriteLine($"The value of index {counter} is {newRandomNumbers[counter]}");
                counter++;
            }

            //Output the number 3
            //the variable stored in the array "numbers" at index "2" has a value of 3
            Console.WriteLine($"Variable at index two is: {numbers[2]}");

            foreach (string name in classNames)
            {
                Console.WriteLine($"Student Name: {name}");
            }




            int timesTableMax = 9;

            int[][] timesTable = new int[9][];

            for (int x = 0; x <= timesTableMax; x++)
            {
                timesTable[x] = new int[8];
                //1 - 9
                for(int y = 0; y <= timesTableMax; y++)
                {
                    //writeline creates a new line and write just continues to print until the end 
                    //Console.Write($"x: {x}, y: {y}, the product is: {x * y}");
                    Console.Write($"{x * y}");
                    //gives us 
                    timesTable[x - 1][y - 1] = x * y;
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        
        
        
        }
    }
}
