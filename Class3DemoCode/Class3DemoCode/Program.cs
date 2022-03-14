using System;

namespace Class3DemoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged arrays

            //2 array with 3 elements
            int[][] simpleJaggedArray = new int[4][]
            {
                new int[]{ 1,2,3,},
                new int[]{1},
                new int[]{1,2},
                new int[]{1, 2, 3, 4, 5},
            };

            foreach(int[] outerloop in simpleJaggedArray)
            {
                foreach(int value in outerloop)
                {
                    Console.Write(" " + value + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
