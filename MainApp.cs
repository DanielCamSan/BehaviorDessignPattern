using BehaviorDessignPattern.Client;
using BehaviorDessignPattern.MeansOfTransport;
using System;

namespace BehaviorDessignPattern
{
    class MainApp
    {
        static void Main(string[] args)
        {            
            Crew crew = new Crew();

            crew.Tripulation.Add(new Passenger("Daniel", 5918928, 25));
            crew.Tripulation.Add(new Passenger("Sergio", 5918926, 20));
            crew.Tripulation.Add(new Passenger("Andres", 5918958, 18));
            crew.SetTripStrategy(new Bus());
            Console.WriteLine($"You travel in {crew.TravelTime()} hours at {crew.NameTravel()}.");
            crew.SetTripStrategy(new Boat());
            Console.WriteLine($"You travel in {crew.TravelTime()} hours at {crew.NameTravel()}.");
            crew.SetTripStrategy(new Train());
            Console.WriteLine($"You travel in {crew.TravelTime()} hours at {crew.NameTravel()}.");
            crew.SetTripStrategy(new Plane());
            Console.WriteLine($"You travel in {crew.TravelTime()} hours at {crew.NameTravel()}.");
        }
    }
}
