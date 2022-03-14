using Class4DemoCode.Entities;
using System;

namespace Class4DemoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vehicle myVehicle = new Vehicle();

            Car secondVehicle = new Car("Tabaxi", 4);
            Console.WriteLine(secondVehicle);*/


            Pickup fordF1 = new Pickup(15000, "Clifford", 2, engineType.Combustion);
            fordF1.unloadPassenger();
            Console.WriteLine(fordF1);
            


            Console.ReadKey();

        }
    }
}
