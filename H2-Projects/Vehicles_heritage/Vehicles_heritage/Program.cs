using System;

namespace Vehicles_heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicle_BMW = new PersonalVehicle("PersonalVehicle", "BMW", 500, true);
            PersonalVehicle Personalvehicle_BMW = new PersonalVehicle("PersonalVehicle", "BMW", 500, true);

            Console.WriteLine("Navn: " + vehicle_BMW.GetName());
            if (vehicle_BMW.SetVehicleName == null)
            {
                Console.WriteLine("Vehicle name can't be null");
            }
            try
            {
                vehicle_BMW.Km(200);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Registreringsnummer: " + vehicle_BMW.RegistrationNumber);
            Console.WriteLine("Årgang: " + vehicle_BMW.Year);
            vehicle_BMW.NewPrice(20000);
            vehicle_BMW.TowingHook(true);
            Console.Write("DrivingLicnseType: " + vehicle_BMW.GetDrivingLicnse());
            if (vehicle_BMW.SetDrivingLicnse == null)
            {
                Console.WriteLine("Vehicle not spicified!");
            }       
            try
            {
                vehicle_BMW.EngineSize(5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Personalvehicle_BMW.Seats(5);
            Personalvehicle_BMW.Isofix = true;
            Personalvehicle_BMW.SecurityHang = true;
            Personalvehicle_BMW.Baggage(10, 15, 20);
            Console.WriteLine("Weight: " + Personalvehicle_BMW.capacity + " license type needed: " + Personalvehicle_BMW.LicenseType(" B"));
            

            //Vehicles veicleTruck_BMW = new Truck(2000, true);
            //Truck truck_BMW = new Truck(2000, true);

            //Console.WriteLine("Lasteevne: " + truck_BMW.capacity + " kg");


            //Vehicles veicleBus_BMW = new Bus(true, true);
            //Bus Bus_BMW = new Bus(true, true);

        }
    }
}
