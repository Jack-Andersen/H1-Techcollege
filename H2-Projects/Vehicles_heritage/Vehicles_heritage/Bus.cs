using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage
{
    class Bus : Vehicles
    {

        public bool Toliets;
        public bool Towing;

        public Bus(string vehicle, string vehicleName, int weight, bool towingHook, bool Toliets) : base(vehicle, vehicleName, weight, towingHook)
        {
            this.Toliets = Toliets;
            this.Towing = towingHook;
        }

        public void Seats(int seats)
        {
            Console.WriteLine(" Sidde pladser: " + seats);
        }
        public void SleepingPlaces(int place)
        {
            Console.WriteLine(" Soveplader: " + place);
        }

        public bool ContainsToliets(bool type)
        {
            if (Toliets == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Height(int h)
        {
            Console.WriteLine(" Højde: " + h);
        }

        public void Weight(int w)
        {
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
