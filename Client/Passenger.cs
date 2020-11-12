using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviorDessignPattern.Client
{
    public class Passenger
    {
        public string Name { get; set; }
        public int Ci { get; set; }
        public int Age { get; set; }
        public Passenger(string name,int ci,int age)
        {
            Name = name;
            Ci = ci;
            Age = age;
        }
    }
}
