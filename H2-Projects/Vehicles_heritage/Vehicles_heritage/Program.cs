using System;
using System.Collections.Generic;
using Vehicles_heritage.AuctionHouse_AH;

namespace Vehicles_heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ProfessionalPersonalvehicle...

            // Values
            string personal_Vehicle = "ProfessionalPersonalvehicle";
            string personal_VehicleName = "BMW";
            double personal_Km = 500;
            string personal_RegistrationNumber = "KL66612";
            int personal_Year = 2012;
            double personal_NewPrize = 200000;
            bool personal_Towbar = true;
            double personal_EngineSize = 10;
            double personal_KmPerLiter = 14;
            Vehicles.fuelTypeEnum personal_Fuel = Vehicles.fuelTypeEnum.Benzin;
            int personal_NumberOfSeats = 2;
            PersonalVehicle.trunkDimentionsStruct personal_Td;
            personal_Td.height = 14.0;
            personal_Td.width = 10.0;
            personal_Td.depth = 16.0;
            double personal_LoadCapacity = 750;

            //New inheritance of an object
            ProfessionalPersonalvehicle vehicle_BMW = new ProfessionalPersonalvehicle(personal_Vehicle, personal_VehicleName, personal_Km, personal_RegistrationNumber, personal_Year, personal_NewPrize, personal_Towbar, personal_EngineSize, personal_KmPerLiter, personal_Fuel, personal_NumberOfSeats, personal_Td, personal_LoadCapacity);
            //Console.WriteLine(vehicle_BMW.ToString() + "\n");
            #endregion

            #region Truck...

            // Values
            string truck_Vehicle = "Truck";
            string truck_VehicleName = "BMW2";
            double truck_Km = 500;
            string truck_RegistrationNumber = "KL66612";
            int truck_Year = 2012;
            double truck_NewPrize = 200000;
            bool truck_Towbar = true;
            double truck_EngineSize = 10;
            double truck_KmPerLiter = 14;
            Vehicles.fuelTypeEnum truck_Fuel = Vehicles.fuelTypeEnum.Benzin;
            Truck.trunkDimentionsStruct truck_Td;
            truck_Td.height = 14.0;
            truck_Td.width = 10.0;
            truck_Td.depth = 16.0;
            double truck_LoadCapacity = 750;

            //New inheritance of an object
            Truck truck = new Truck(truck_Vehicle, truck_VehicleName, truck_Km, truck_RegistrationNumber, truck_Year, truck_NewPrize, truck_Towbar, truck_EngineSize, truck_KmPerLiter, truck_Fuel, truck_Td, truck_LoadCapacity);
            //Console.WriteLine(truck.ToString() + "\n");
            #endregion

            #region Bus...
            // Values
            string bus_Vehicle = "Bus";
            string bus_VehicleName = "BMW3";
            double bus_Km = 500;
            string bus_RegistrationNumber = "KL66612";
            int bus_Year = 2012;
            double bus_NewPrize = 200000;
            bool bus_Towbar = true;
            double bus_EngineSize = 10;
            double bus_KmPerLiter = 14;
            Vehicles.fuelTypeEnum bus_Fuel = Vehicles.fuelTypeEnum.Benzin;
            bool bus_Toliets = true;
            int bus_NumberOfSeats = 2;
            int but_sleepingplaces = 2;
            Bus.trunkDimentionsStruct bus_Td;
            bus_Td.height = 14.0;
            bus_Td.width = 10.0;
            bus_Td.depth = 16.0;

            //New inheritance of an object
            Bus bus = new Bus(bus_Vehicle, bus_VehicleName, bus_Km, bus_RegistrationNumber, bus_Year, bus_NewPrize, bus_Towbar, bus_EngineSize, bus_KmPerLiter, bus_Fuel, bus_Toliets, bus_NumberOfSeats, but_sleepingplaces, bus_Td);
            //Console.WriteLine(bus.ToString() + "\n");
            #endregion

            #region ListOfVehicles...
            //Adding Vehicles to a List

            List<Vehicles> Auctionvehicles = new List<Vehicles>();
            Auctionvehicles.Add(vehicle_BMW);
            Auctionvehicles.Add(truck);
            Auctionvehicles.Add(bus);
            foreach (Vehicles vehicle in Auctionvehicles)
            {
                Console.WriteLine(vehicle.ToString() + "\n");
            }
            #endregion

            #region AuctionHouse...
            //Adding Vehicles to the AucionHouse

            //AuctionHouse auctionHouse = new AuctionHouse();
            //auctionHouse.Vehicle.Add(vehicle_BMW);
            //foreach (Vehicles vehicle in auctionHouse.Vehicle)
            //{
            //    Console.WriteLine(vehicle.ToString() + "\n");
            //}
            #endregion

            #region corporateUser...

            //Values
            string corporateUser_Firstname = "Michael";
            string corporateUser_Lastname = "Bitch_Men";
            string corporateUser_Address = "Bitch_Men.Vej40";
            int corporateUser_PhoneNumber = 20241530;
            int corporateUser_ZipCode = 9230;
            decimal corporateUser_Balance = 500M;
            int corporateUser_CvrNumber = 1302921245;
            int creditUser_credit = 44;

            //New inheritance of an object
            User Mads_Bitch_Men = new CorporateUser(corporateUser_Firstname,
                corporateUser_Lastname,
                corporateUser_Address,
                corporateUser_PhoneNumber,
                corporateUser_ZipCode,
                corporateUser_Balance,
                corporateUser_CvrNumber,
                creditUser_credit);
            #endregion

            #region PrivateUser...

            //Values
            string privateUser_Firstname = "Michael";
            string privateUser_Lastname = "Bitch_Men";
            string privateUser_Address = "Bitch_Men.Vej40";
            int privateUser_PhoneNumber = 20241530;
            int privateUser_ZipCode = 9230;
            decimal privateUser_Balance = 500M;
            int privateUser_CprNumber = 1302921245;

            //New inheritance of an object
            User Michael_Bitch_Men = new PrivateUser(privateUser_Firstname,
                privateUser_Lastname,
                privateUser_Address,
                privateUser_PhoneNumber,
                privateUser_ZipCode,
                privateUser_Balance,
                privateUser_CprNumber);
            #endregion

            #region ListOfUser...

            //Adding Users to a List
            List<User> newUser = new List<User>();
            newUser.Add(Michael_Bitch_Men);

            foreach (User user in newUser)
            {
                Console.WriteLine(user.ToString() + "\n");
            }
            #endregion

            AuctionHouse.SetForSale(vehicle_BMW, Michael_Bitch_Men, 55M);

        }
    }
}
