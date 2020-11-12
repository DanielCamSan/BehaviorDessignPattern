using System;
using System.Collections.Generic;
using System.Text;
using BehaviorDessignPattern.Client;

namespace BehaviorDessignPattern.MeansOfTransport
{
    public class Boat : ITrip
    {
        private int _limitPassengers = 6000;
        private string _brand = "Boat";
        public string NameTravel()
        {
            return _brand;
        }
        public int TravelTime(List<Passenger> passengers)
        {
            int respuesta;
            if (passengers.Count > _limitPassengers)
            {
                respuesta = -1;
            }
            else
            {
                return 460;
            }

            return respuesta;
        }
    }
}
