using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TradeTracker.DATA.Enums
{
    public enum OrderType
    {
        [Display(Name ="Buy Market")]
        BuyMarket,

        [Display(Name="Buy Stop")]
        BuyStop,

        [Display(Name = "Buy Limit")]
        BuyLimit,

        [Display(Name = "Sell Market")]
        SellMarket,

        [Display(Name = "Sell Stop")]
        SellStop,

        [Display(Name = "Sell Limit")]
        SellLimit
    }
}
