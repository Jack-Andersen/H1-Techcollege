using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage
{
    class PersonalVehicle : Vehicles
    {

        public bool Isofix;
        public bool SecurityHang;
        public int capacity;

        public PersonalVehicle(string vehicle, string vehicleName, int weight, bool towingHook) : base(vehicle, vehicleName, weight, towingHook)
        {
            this.capacity = weight;
        }

        public void Seats(int seats)
        {
            if(seats  >= 1 && seats <= 3)
            {
                Console.WriteLine("Privat pervogn med " + seats + " sæder. ");
            }
            else if(seats >= 3 && seats <= 7)
            {
                Console.WriteLine("Privat personvogn med " + seats + " sæder. ");
            }
            else
            {
                Console.WriteLine(seats + " Passer ikke til personvogn ");
            }
        }

        public void Baggage( int l, int b, int h)
        {
            Console.WriteLine("Længde: " + l + " Bredde: " + b + " Højde: " + h);
        }

        public string LicenseType(string type)
        {
            if(capacity >= 750)
            {
                return "BE";
            }
            else
            {
                return "B";
            }
        }
    }
}
