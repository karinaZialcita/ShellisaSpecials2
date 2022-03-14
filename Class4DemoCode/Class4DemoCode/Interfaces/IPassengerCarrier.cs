using System;
using System.Collections.Generic;
using System.Text;

namespace Class4DemoCode.Interfaces
{
    interface IPassengerCarrier
    {
        //keep a count of passengers
        public int  numberOfPassengers{ get; set; }


        //common Functionality for
        public void loadPassenger();
        public void unloadPassenger();

        //not supposed to be implemented



    }
}
