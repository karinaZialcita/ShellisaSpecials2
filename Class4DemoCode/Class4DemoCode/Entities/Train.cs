using Class4DemoCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class4DemoCode.Entities
{
    class Train : Vehicle, IPassengerCarrier
    {
        //implemented for IPassengerCarrier
        public int numberOfPassengers { get; set; }

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

    }
}
