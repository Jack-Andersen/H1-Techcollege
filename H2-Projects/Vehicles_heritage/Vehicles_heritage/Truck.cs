using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage
{

    class Truck : Vehicles
    {
        public Truck(string vehicle,
            string vehicleName,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            trunkDimentionsStruct trunkDimentions,
            double loadCapacity) : base(vehicle, vehicleName, km, registrationNumber, year, newPrice, towbar, kmPerLiter, fuelType)
        {
            this.Towbar = towbar;
            this.EngineSize = engineSize;
            this.TrunkDimentions = trunkDimentions;
            this.LoadCapacity = loadCapacity;
        }

        //fields and probertys
        public bool Towbar
        {
            get { return towbar; }
            set { towbar = value; }
        }
        public bool towbar;

        public override double EngineSize
        {
            get { return this.engineSize; }
            set
            {
                if (value < 4.2 || value > 15.0)
                    throw new ArgumentOutOfRangeException(
                          " must be between 4.2 and 15.0 L.");

                this.engineSize = value;
            }
        }

        public double LoadCapacity
        {
            get { return loadCapacity; }
            set { loadCapacity = value; }
        }
        public double loadCapacity;

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
        
        //Returns the Truck in a string
        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3} \n {4}: {5}\n",
                nameof(this.TrunkDimentions),
                this.TrunkDimentions.ToString(),
                nameof(this.Towbar),
                this.Towbar,
                nameof(this.LoadCapacity),
                this.LoadCapacity
                );
        }
    }
}

