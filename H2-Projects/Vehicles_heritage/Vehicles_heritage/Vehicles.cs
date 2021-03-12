using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicles_heritage
{
    abstract class Vehicles
    {

        public string Vehicle;

        protected Vehicles(string vehicle,
            string vehicleName,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double kmPerLiter,
            fuelTypeEnum fuelType)
        {
            this.Vehicle = vehicle;
            this.VehicleName = vehicleName;
            this.Km = km;
            this.RegistrationNumber = registrationNumber;
            this.Year = year;
            this.NewPrice = newPrice;
            this.KmPerLiter = kmPerLiter;
            this.FuelType = fuelType;
            this.engeryClass = GetEnergyClass();

        }

        //fields and probertys
        public string VehicleName
        {
            get { return vehicleName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Parameter can't be null");
                }
                vehicleName = value;
            }
        }
        private string vehicleName;

        public double Km
        {
            get { return km; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can't be negative");
                }
                km = value;
            }
        }
        private double km;

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set 
            {
                var r = new Regex(@"^[a-zA-Z]{2}\d{5}$");
                if (!r.IsMatch(value))
                {
                    throw new Exception("Registreringsnummeret er ikke gyldigt!");
                }
                registrationNumber = value;     
            }
        }

        //Method for hidding numbers in RegistrationNumber
        public string ShowRegistrationNumber()
        {
            return "**" + registrationNumber.Substring(2, 3) + "**";
        }

        private string registrationNumber;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private int year;

        public double NewPrice
        {
            get { return newPrice; }
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can't be negative");
                }    
                newPrice = value; 
            }
        }
        private double newPrice;

        public bool Towbar
        {
            get { return towbar; }
            set { towbar = value; }
        }
        private bool towbar;

        //Enum's, field and proberty
        public driversLisenceEnum DriversLisence
        {
            get { return driversLisence; }
            set { driversLisence = value; }
        }
        private driversLisenceEnum driversLisence;
        public enum driversLisenceEnum
        {
            A,
            B,
            C,
            D,
            BE,
            CE,
            DE
        }

        //fields and probertys
        public virtual double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }
        protected double engineSize;

        public double KmPerLiter
        {
            get { return kmPerLiter; }
            set { kmPerLiter = value; }
        }
        private double kmPerLiter;

        //Enum's, field and proberty
        public fuelTypeEnum FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        private fuelTypeEnum fuelType;
        public enum fuelTypeEnum
        {
            Diesel,
            Benzin
        }

        public energyClassEnum EngeryClass
        {
            get { return engeryClass; }
        }
        private energyClassEnum engeryClass;
        public enum energyClassEnum
        {
            A,
            B,
            C,
            D
        }

        // Engery class is calculated bassed on year of the car and the efficiancy in km/L.
        // Returns the energy class in engeryClassEnum (A,B,C,D).
        private energyClassEnum GetEnergyClass()
        {
            if (this.year < 2010)
            {
                if (this.fuelType is fuelTypeEnum.Diesel)
                {
                    if (this.kmPerLiter >= 23.0)
                    {
                        return energyClassEnum.A;
                    }
                    else if (this.kmPerLiter < 23.0 && this.kmPerLiter >= 18.0)
                    {
                        return energyClassEnum.B;
                    }
                    else if (this.kmPerLiter < 18.0 && this.kmPerLiter >= 13.0)
                    {
                        return energyClassEnum.C;
                    }
                    else if (this.kmPerLiter < 13.0)
                    {
                        return energyClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    if (this.kmPerLiter >= 18.0)
                    {
                        return energyClassEnum.A;
                    }
                    else if (this.kmPerLiter < 18.0 && this.kmPerLiter >= 14.0)
                    {
                        return energyClassEnum.B;
                    }
                    else if (this.kmPerLiter < 14.0 && this.kmPerLiter >= 10.0)
                    {
                        return energyClassEnum.C;
                    }
                    else if (this.kmPerLiter < 10.0)
                    {
                        return energyClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            else
            {
                if (this.fuelType is fuelTypeEnum.Diesel)
                {



                    if (this.kmPerLiter >= 25.0)
                    {
                        return energyClassEnum.A;
                    }
                    else if (this.kmPerLiter >= 25 && this.kmPerLiter >= 20.0)
                    {
                        return energyClassEnum.B;
                    }
                    else if (this.kmPerLiter >= 20 && this.kmPerLiter >= 15.0)
                    {
                        return energyClassEnum.C;
                    }
                    else if (this.kmPerLiter >= 15)
                    {
                        return energyClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    if (this.kmPerLiter >= 20.0)
                    {
                        return energyClassEnum.A;
                    }
                    else if (this.kmPerLiter < 20.0 && this.kmPerLiter >= 16.0)
                    {
                        return energyClassEnum.B;
                    }
                    else if (this.kmPerLiter < 16.0 && this.kmPerLiter >= 12.0)
                    {
                        return energyClassEnum.C;
                    }
                    else if (this.kmPerLiter < 12)
                    {
                        return energyClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        //Returns the vehicle in a string with the given information.
        public new virtual string ToString()
        {
            return String.Format(" {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: " + ShowRegistrationNumber() +
                " \n {7}: {8}\n {9}: {10}\n {11}: {12}\n {13}: {14}\n {15}: {16}\n {17}: {18}\n {19}: {20}\n",
                nameof(this.Vehicle),
                this.Vehicle,
                nameof(this.VehicleName),
                this.vehicleName,
                nameof(this.Km),
                this.Km,
                nameof(this.RegistrationNumber),
                nameof(this.Year),
                this.Year,
                nameof(this.NewPrice),
                this.NewPrice,
                nameof(this.EngineSize),
                this.EngineSize,
                nameof(this.KmPerLiter),
                this.KmPerLiter,
                nameof(this.DriversLisence),
                this.DriversLisence,
                nameof(this.FuelType),
                this.FuelType,
                nameof(this.EngeryClass),
                this.EngeryClass
                );
        }

        internal AuctionHouse_AH.Auction Auction
        {
            get => default;
            set
            {
            }
        }
    }
}
