using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicles_heritage
{

    abstract class PersonalVehicle : Vehicles
    {
        public PersonalVehicle(string vehicle,
            string vehicleName,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeats,
            trunkDimentionsStruct trunkDimentions) : base(vehicle, vehicleName, km, registrationNumber, year, newPrice, towbar, kmPerLiter, fuelType)
        {
            this.NumberOfSeats = numberOfSeats;
            this.TrunkDimentions = trunkDimentions;
            this.EngineSize = engineSize;
        }

        //fields and probertys
        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set
            {
                var r = new Regex(@"^[2-7]{1}$");

                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Antal sæder er ikke gyldigt!");

                else
                    numberOfSeats = value;
            }
        }
        private int numberOfSeats;

        //TrunkDimentions field, proberty and struct
        public trunkDimentionsStruct TrunkDimentions
        {
            get { return trunkDimentions; }
            set { trunkDimentions = value; }
        }
        private trunkDimentionsStruct trunkDimentions;
        public struct trunkDimentionsStruct
        {
            public double height;
            public double width;
            public double depth;
            public override string ToString() => $"({height}, {width}, {depth})";
        }

        //fields and probertys
        public override double EngineSize
        {
            get { return this.engineSize; }
            set
            {
                if (value < 0.7 || value > 10.0)
                    throw new ArgumentOutOfRangeException(
                          " must be between 0.7 and 10.0 L.");

                this.engineSize = value;
            }
        }

        //Returns the PersonalCar in a string
        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}",
                nameof(this.NumberOfSeats),
                this.NumberOfSeats,
                nameof(this.TrunkDimentions),
                this.TrunkDimentions.ToString()
                );
        }
    }

    class PrivatePersonalvehicle : PersonalVehicle
    {
        public PrivatePersonalvehicle(string vehicle,
            string vehicleName,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeats,
            trunkDimentionsStruct trunkDimentions,
            bool isofixFittings) : base(vehicle, vehicleName, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType, numberOfSeats, trunkDimentions)
        {
            this.IsofixFittings = isofixFittings;
            this.DriversLisence = driversLisenceEnum.B;
        }

        //fields and probertys
        public bool IsofixFittings
        {
            get { return isofixFittings; }
            set { isofixFittings = value; }
        }
        private bool isofixFittings;

        //Returns the PrivatePersonalvehicle in a string
        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n",
                nameof(this.IsofixFittings),
                this.IsofixFittings
                );
        }
    }

    class ProfessionalPersonalvehicle : PersonalVehicle
    {
        public ProfessionalPersonalvehicle(string vehicle,
            string vehicleName,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeats,
            trunkDimentionsStruct trunkDimentions,
            double loadCapacity) : base(vehicle, vehicleName, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType, numberOfSeats, trunkDimentions)
        {
            this.Towbar = towbar;
            this.NumberOfSeats = 2;
            this.LoadCapacity = loadCapacity;

            if (this.loadCapacity > 750.0)
            {
                this.DriversLisence = driversLisenceEnum.BE;
            }
            else
            {
                this.DriversLisence = driversLisenceEnum.B;
            }
        }

        //fields and probertys
        public bool Towbar
        {
            get { return towbar; }
            set { towbar = value; }
        }
        public bool towbar;
        public double LoadCapacity
        {
            get { return loadCapacity; }
            set { loadCapacity = value; }
        }
        public double loadCapacity;

        //Returns the ProfessionalPersonalvehicle in a string
        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}\n",
                nameof(this.Towbar),
                this.Towbar,
                nameof(this.LoadCapacity),
                this.LoadCapacity
                );
        }
    }
}
