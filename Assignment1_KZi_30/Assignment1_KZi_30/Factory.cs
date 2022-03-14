using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_KZi_30
{
    class Factory
    {
        public  Model modelType { get; set; }

        public int[] TruckArray = new int[50];

        int numOfSeries = 8;

        
        private string[] modelArray = {};
/*        public void fillArray()
        {
            for (int )
        }
*/


        public Factory()
        {
            Console.WriteLine("constructor has been called");
        }



        public void GenerateTrucks()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, TruckArray.Length);
            Console.WriteLine($"Count for " + Model.F1 + " series trucks is:" + randomNum);
            int newRand = rand.Next(1, TruckArray.Length - randomNum); 
            Console.WriteLine($"Count for " + Model.F2 + " series trucks is:" + newRand);      int newRand2 = rand.Next(1, TruckArray.Length - (newRand+randomNum)); 
            Console.WriteLine($"Count for " + Model.F3 + " series trucks is:" + newRand2);      int newRand3 = rand.Next(1, TruckArray.Length - (newRand2+newRand));
            Console.WriteLine($"Count for " + Model.F4 + " series trucks is:" + newRand3);
            
            int newRand4 = rand.Next(1, TruckArray.Length - (newRand2 + newRand3));
            Console.WriteLine($"Count for " + Model.F5 + " series trucks is:" + newRand4);
            int newRand5 = rand.Next(1, TruckArray.Length - (newRand3 + newRand4)); 
            Console.WriteLine($"Count for " + Model.F6 + " series trucks is:" + newRand5);      int newRand6 = rand.Next(1, TruckArray.Length - (newRand5 + newRand4)); 
            Console.WriteLine($"Count for " + Model.F7 + " series trucks is:" + newRand6);      int newRand7 = rand.Next(1, TruckArray.Length - (newRand6+newRand5));
            Console.WriteLine($"Count for " + Model.F8 + " series trucks is:" + newRand7);


        }


    }
}
