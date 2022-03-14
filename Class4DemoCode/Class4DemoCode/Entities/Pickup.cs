using Class4DemoCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Class4DemoCode.Entities
{
    class Pickup : Car, IPassengerCarrier
    {


        public double LoadCapacity { get; set; }

        public engineType currentEngine { get; set; }

        //set the max capacity of the pickup
        private int maxCapacity = 2;
        private int currentCapacity = 0;

        //implemented for IPassengerCarrier
        public int numberOfPassengers { 
            get { return currentCapacity; } 
            set
            {
                //specify set
                if( (currentCapacity + value) > maxCapacity )
                {
                    Console.WriteLine("You cannot have that many passengers in your pickup!");
                } else
                {
                    currentCapacity += value;
                }
            }
        }

        


        public Pickup(double NewLoadCapacity, string NewName, int NewNumberOfDoors, engineType NewEngineType) : base (NewName, NewNumberOfDoors)
        {
            this.LoadCapacity = NewLoadCapacity;
            this.currentEngine = NewEngineType;

        }

        //implemented for IPassengerCarrier
        //this function will increase the number of passengers
        public void loadPassenger()
        {
            this.numberOfPassengers++;
        }

        public void unloadPassenger()
        {
            this.numberOfPassengers--;
        }


        public override string ToString()
        {

            //declare an object of "type"
            Type Pickup = typeof(Pickup);
            //get properties and put them in an array
            PropertyInfo[] propertyInfo = Pickup.GetProperties();


            StringBuilder manifest = new StringBuilder();

            foreach(PropertyInfo property in propertyInfo)
            {
                ///doesnt show private methods 
                manifest.Append(property.Name + " : " + property.GetValue(this) + "\n");

            }
            return manifest.ToString();

        }

    }
}
