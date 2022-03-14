using System;
using System.Collections.Generic;
using System.Text;

namespace Class4DemoCode.Entities
{
    class Vehicle
    {
        public bool isRunning = false;


        //prop hit tab x2
        public string name { get; set; }

        public int numOfWheels { get; set; }
        public Vehicle()
        {
            Console.WriteLine("The default constructor has been called! ");


        }

        //user defined constructor
        public Vehicle(string NewName, int newNumberOfWheels)
        {
            this.name = NewName;
            this.numOfWheels = newNumberOfWheels;



        }
        //overried the toString func
        public override string ToString()
        {
            return " The Vehicle is called " + this.name + " and it has " + this.numOfWheels + " wheels.";

        }



    }
}
