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
            this.UserSeller = (User)seller;
        }

        public decimal Bid
        {
            get => default;
            set { }
        }
        private decimal bid;

        internal Vehicles Vehicle
        {
            get => default;
            set
            {
            }
        }
        public Vehicles vehicle;

        internal User UserSeller
        {
            get => default;
            set
            {
            }
        }
        private User seller;

        internal User UserBuyer
        {
            get => default;
            set
            {
            }
        }
        private User Userbuyer;

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
