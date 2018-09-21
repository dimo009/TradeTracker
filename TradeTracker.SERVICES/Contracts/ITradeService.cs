

namespace TradeTracker.SERVICES.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using TradeTracker.DATA.Enums;
    using TradeTracker.DATA.Models;
    using TradeTracker.SERVICES.Models;

    public interface ITradeService
    {
        IEnumerable<TradesListModel> AllTrades();

        IEnumerable<TradesListModel> AllClosedTrades();

        IEnumerable<TradesListModel> AllOpenTrades();

        IEnumerable<TradesListModel> AllPendingTrades();

        TradeDetailsModel ShowDetails(string id);

       DeleteTradeModel FindTrade(string id);

        void AddTrade(TradedPair pair, OrderType orderType, TradeStatus status, double size, double? executionPrice,
            DateTime? executionDate, double? closingPrice, DateTime? closingDate, double? stopLoss, double? takeProfit,
            ReasonForEntry reason, double? swap, double? commissions, string notes, byte[]image);

       

        bool Exists(string id);

        EditTradeModel FindTradeById(string id);

        void EditTrade(string id, TradedPair pair, OrderType orderType, TradeStatus status, double size, double? executionPrice,
           DateTime? executionDate, double? closingPrice, DateTime? closingDate, double? stopLoss, double? takeProfit,
           ReasonForEntry reason, double? swap, double? commissions, string notes, byte[] image);

        void Delete(string id);

    }
}
