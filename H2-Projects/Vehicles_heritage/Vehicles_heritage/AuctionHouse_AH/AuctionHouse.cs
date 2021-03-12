using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage.AuctionHouse_AH
{
    class AuctionHouse
    {

        //public AuctionHouse()
        //{
        //    this.Auctions = new List<Auction>();
        //}
        //public List<Auction> Auctions;

                                        //BmW Vehical           //Micheal        //22
        public static Auction SetForSale (Vehicles vehicleType, ISellerModel seller, decimal myPrice)
        {

            Auction auction = new Auction(vehicleType, seller, myPrice);
            auction.Vehicle.ToString();

            return auction;

        }

        public static int SetForSale(Vehicles vehicleType, ISellerModel seller, decimal myPrice, Func<string> bidnodfication)
        {
            //if ()
            //{
                bidnodfication();
                Console.WriteLine(seller.ZipCode);
            //}
            
            throw new NotImplementedException();
        }

        public static bool OfferRecieved(IBuyerModel Buyer, int auktionsNumber, decimal bid)
        {
            throw new NotImplementedException();
        }

        public static bool AcceptOffer(ISellerModel Seller, int auktionsNumber)
        {

            throw new NotImplementedException();

            //if (AcceptOffer(Seller, auktionsNumber) == true)
            //{

            //}
        }

        public List<Vehicles> vehicle;

    }
}
