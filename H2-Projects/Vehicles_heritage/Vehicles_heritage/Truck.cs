using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage
{
    class Truck : Vehicles
    {

        public int capacity;
        public bool Towing;

        public Truck(string vehicle, string vehicleName, int weight, bool towingHook) : base(vehicle, vehicleName, weight, towingHook)
        {
            this.capacity = weight;
            this.Towing = towingHook; 
        }

        public void Height(int h)
        {
            Console.WriteLine(" Højde: " + h);
        }

        public void Weight(int w)
        {
            w = capacity;
            Console.WriteLine(" vægt: " + w);
        }

        public void Lenght(int l)
        {
            Console.WriteLine(" længde: " + l);
        }
        public string LicenseType(bool type)
        {
            if (Towing)
            {
                return "C";
            }
            else
            {
                return "CE";
            }
        }
    }
}
