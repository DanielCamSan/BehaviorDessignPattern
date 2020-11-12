using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviorDessignPattern.Client
{
    public class Crew
    {
        public ITrip TripStrategy { get; set; }
        public List<Passenger> Tripulation { get; set; }

        public Crew()
        {
            Tripulation = new List<Passenger>();
        }
        public void SetTripStrategy(ITrip strategy)
        {
            TripStrategy = strategy;
        }

        public int TravelTime()
        {
            return TripStrategy.TravelTime(Tripulation);
        }
        public string NameTravel()
        {
            return TripStrategy.NameTravel();
        }
    }
}
