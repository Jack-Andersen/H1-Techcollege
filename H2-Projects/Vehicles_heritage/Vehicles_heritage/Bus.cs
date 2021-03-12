using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicles_heritage
{

    class Bus : Vehicles
    {
        public Bus(string vehicle,
            string vehicleName,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            bool toilet,
            int numberOfSeats,
            int sleepingplaces,
            trunkDimentionsStruct trunkDimentions) : base(vehicle, vehicleName, km, registrationNumber, year, newPrice, towbar, kmPerLiter, fuelType)
        {
            this.Toilet = toilet;
            this.NumberOfSeats = numberOfSeats;
            this.Sleepingplaces = sleepingplaces;
            this.TrunkDimentions = trunkDimentions;
            this.EngineSize = engineSize;
        }

        //fields and probertys
        public bool Toilet
        {
            get { return toilet; }
            set { toilet = value; }
        }
        public bool toilet;

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

        public int Sleepingplaces
        {
            get { return sleepingplaces; }
            set
            {
                var r = new Regex(@"^[2-7]{1}$");

                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Antal sover plader er ikke gyldigt!");

                else
                    sleepingplaces = value;
            }
        }
        private int sleepingplaces;

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
                if (value < 4.2 || value > 15.0)
                    throw new ArgumentOutOfRangeException(
                          "Must be between 4.2 and 15.0 L.");

                this.engineSize = value;
            }
        }

        //Returns the Bus in a string
        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n",
                nameof(this.Toilet),
                this.Toilet,
                nameof(this.NumberOfSeats),
                this.NumberOfSeats,
                nameof(this.Sleepingplaces),
                this.Sleepingplaces,
                nameof(this.TrunkDimentions),
                this.TrunkDimentions.ToString()
                );
        }
    }
}
