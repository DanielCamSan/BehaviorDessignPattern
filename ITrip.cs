using BehaviorDessignPattern.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviorDessignPattern
{
    public interface ITrip
    {
        public string NameTravel();
        public int TravelTime(List<Passenger> passengers);
        
    }
}
