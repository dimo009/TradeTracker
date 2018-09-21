
namespace TradeTracker.WEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TradeTracker.SERVICES.Models;

    public class TradesListViewModel
    {
        
        public IEnumerable<TradesListModel> AllTrades { get; set; }
    }
}
