using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TradeTracker.DATA.Enums
{
    public enum TradeStatus
    {
        Open,

        [Display(Name = "Pending order")]
        PendingOrder,

        Closed

    }
}
