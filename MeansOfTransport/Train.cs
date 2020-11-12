using System;
using System.Collections.Generic;
using System.Text;
using BehaviorDessignPattern.Client;

namespace BehaviorDessignPattern.MeansOfTransport
{
    public class Train : ITrip
    {
        private int _limitPassengers = 240;
        private string _brand = "Train";
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
                return 600;
            }

            return respuesta;
        }
    }
}
