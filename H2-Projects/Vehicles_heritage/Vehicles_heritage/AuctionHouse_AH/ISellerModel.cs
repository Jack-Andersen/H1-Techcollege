using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_heritage.AuctionHouse_AH
{
    public interface ISellerModel
    {

        int ZipCode { get; set; }

        string BidNotification();

    }
}
