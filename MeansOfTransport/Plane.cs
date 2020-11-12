using System;
using System.Collections.Generic;
using System.Text;
using BehaviorDessignPattern.Client;
namespace BehaviorDessignPattern.MeansOfTransport
{
    public class Plane : ITrip
    {
        private int _limitPassengers = 530;
        private string _brand = "Plane";
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
                return 150;
            }

            return respuesta;
        }
    }
}
