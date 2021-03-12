using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage.AuctionHouse_AH
{
    class Auction
    {
        public Auction(Vehicles vehicleType, ISellerModel seller, decimal myPrice)
        {
            this.Bid = myPrice;
            this.Vehicle = vehicleType;
            this.Seller = (User)seller;
        }

        public decimal Bid
        {
            get { }
            set { }
        }
        private decimal bid;

        public Vehicles Vehicle
        {
            get;
        }
        public Vehicles vehicle;

        public User Seller
        {
            get;
        }
        private User seller;

        public User Buyer
        {
            get { }
            set { }
        }
        private User buyer;

        internal Vehicles Vehicles
        {
            get => default;
            set
            {
            }
        }

        internal User User
        {
            get => default;
            set
            {
            }
        }

        //get { return cprNumver; }
        //set { cprNumber = value; }

    }
    

    //public class Auction
    //{
    //    int id;
    //    double StandingBid;
    //}

    //internal Vehicles Vehicle
    //{
    //    get => default;
    //    set
    //    {

    //    }
    //}

    //internal User Seller
    //{
    //    get => default;
    //    set
    //    {

    //    }
    //}

    //internal User Buyer
    //{
    //    get => default;
    //    set
    //    {

    //    }
    //}
}
