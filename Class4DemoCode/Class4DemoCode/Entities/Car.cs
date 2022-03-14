using System;
using System.Collections.Generic;
using System.Text;

namespace Class4DemoCode.Entities
{
    class Car : Vehicle
    {
        public int numberOfDoors { get; set; }


        public Car() { }
        public Car(string NewName, int NewNumOfDoors) : base(NewName, 4)
        {
            ///save the number of doors; // "this" indicates that the called method comes from the same class
            this.numberOfDoors = NewNumOfDoors;


        }


    }
}
