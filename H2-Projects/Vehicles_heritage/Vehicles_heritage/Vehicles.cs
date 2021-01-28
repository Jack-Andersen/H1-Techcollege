using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage
{
    public class Vehicles
    {

        public string Vehicle;
        public string SetVehicleName;
        public int capacity;
        public bool Towing;
        public string SetDrivingLicnse;

        public Vehicles(string vehicle, string vehicleName, int Weight, bool towingHook)
        {
            this.Vehicle = vehicle;
            try
            {
                this.SetVehicleName = Name(vehicleName);
            }
            catch
            {
                this.SetVehicleName = null;
            }
            this.capacity = Weight;
            this.Towing = towingHook;
            try
            {
                this.SetDrivingLicnse = DrivingLicenseType(vehicle);
            }
            catch
            {
                this.SetDrivingLicnse = null;
            }
           
        }

        public string GetName()
        {
            return SetVehicleName;
        }

        public string Name(string vehicleName)
        {

            if (vehicleName == "")
            {
                throw new Exception("Parameter kan ikke være null");
            }
            else
                return vehicleName;
        }
        public void Km(double km)
        {

            if (km < 0)
            {
                throw new Exception("Kan ikke være negativ");
            }
            else
                Console.WriteLine("Km kørt: " + km);
        }

        public string RegistrationNumber = "11223344aa";

        public int Year = 22;

        public void NewPrice(int newPrice)
        {

            if (newPrice < 0)
            {
                throw new Exception("Kan ikke være negativ");
            }
            else
                Console.WriteLine("Ny pris: " + newPrice);
        }

        public void TowingHook(bool towing)
        {
            if (towing == true)
            {
                Console.WriteLine("Har Anhængertræk");
            }
            else
                Console.WriteLine("Her ikke Anhængertræk");
        }
        public string GetDrivingLicnse()
        {
            return SetDrivingLicnse;
        }
        public string DrivingLicenseType(string type)
        {
            if (Vehicle == "PersonalVehicle" && capacity < 750)
            {
                return "B";
            }
            else if (Vehicle == "PersonalVehicle" && capacity >= 750)
            {
                return "BE";
            }
            else if (Vehicle == "Truck" && Towing == false)
            {
                return "C";
            }
            else if (Vehicle == "Truck" && Towing == true)
            {
                return "CE";
            }
            else if (Vehicle == "Bus" && Towing == false)
            {
                return "D";
            }
            else if (Vehicle == "Bus" && Towing == true)
            {
                return "DE";
            }
            else 
                throw new Exception("Drivinglicensetype does not exist for the Uvo");
                
        }
        public void EngineSize(double EngineSize)
        {
            if (EngineSize >= 0.7 && EngineSize <= 10)
            {
                Console.WriteLine("Motoren > " + EngineSize + " er tilladt");
            }
            else if(EngineSize >= 4.2 && EngineSize <= 15)
            {
                Console.WriteLine("Motoren > " + EngineSize + " er tilladt");
            }
            else
                throw new Exception("Motoren > " + EngineSize + " er ikke tilladt!");

        }
        public double Km_l()
        {
            throw new NotImplementedException();
        }
        public string Fuel()
        {
            throw new NotImplementedException();
        }
        public string EnergyClass()
        {
            throw new NotImplementedException();
        }
    }
}
