using BehaviorDessignPattern.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviorDessignPattern.MeansOfTransport
{
    public class Bus : ITrip
    {
        private int _limitPassengers = 40;
        private string _brand = "Bus";
        public string NameTravel()
        {
            return _brand;
        }
        public int TravelTime(List<Passenger> passengers)
        {
            int respuesta;
            if(passengers.Count>_limitPassengers)
            {
                respuesta = -1;
            }
            else
            {
                return 260;
            }

            return respuesta;
        }
    }
}
