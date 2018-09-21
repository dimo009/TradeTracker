

namespace TradeTracker.SERVICES.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TradeTracker.DATA.Context;
    using TradeTracker.DATA.Enums;
    using TradeTracker.DATA.Models;
    using TradeTracker.SERVICES.Contracts;
    using TradeTracker.SERVICES.Models;

    public class TradeService : ITradeService
    {
        private readonly TradeDbContext tradesDB;

        public TradeService(TradeDbContext tradesDB)
        {
            this.tradesDB = tradesDB;
        }

        public IEnumerable<TradesListModel> AllTrades()
        {
            var trades = this.tradesDB.Trades
                .Select(t => new TradesListModel
                {
                    Id = t.Id,
                    TradePair =t.TradePair,
                    OrderType = t.OrderType,
                    TradeStatus = t.TradeStatus,
                    Quantity = t.Quantity,
                    ExecutionPrice = t.ExecutionPrice,
                    ExecutionDate = t.ExecutionDate,
                    ClosingPrice = t.ClosingPrice,
                    ClosingDate = t.ClosingDate,
                    StopLoss = t.StopLoss,
                    TakeProfit = t.TakeProfit,
                    ReasonForEntry = t.ReasonForEntry,
                    Swap = t.Swap,
                    Commissions = t.Commissions,
                    Notes = t.Notes,
                    Image = t.Image
                    
                }).ToList();

            return trades;
        }

        public IEnumerable<TradesListModel> AllClosedTrades()
        {
            var trades = this.tradesDB.Trades
                .Where(t=>t.TradeStatus.ToString()=="Closed")
                .Select(t => new TradesListModel
                {
                    Id = t.Id,
                    OrderType = t.OrderType,
                    TradeStatus = t.TradeStatus,
                    Quantity = t.Quantity,
                    ExecutionPrice = t.ExecutionPrice,
                    ExecutionDate = t.ExecutionDate,
                    ClosingPrice = t.ClosingPrice,
                    ClosingDate = t.ClosingDate,
                    StopLoss = t.StopLoss,
                    TakeProfit = t.TakeProfit,
                    ReasonForEntry = t.ReasonForEntry,
                    Swap = t.Swap,
                    Commissions = t.Commissions,
                    Notes = t.Notes,
                    Image = t.Image

                }).ToList();

            return trades;
        }

        public IEnumerable<TradesListModel> AllOpenTrades()
        {
            var trades = this.tradesDB.Trades
                .Where(t => t.TradeStatus.ToString() == "Active")
                .Select(t => new TradesListModel
                {
                    Id = t.Id,
                    OrderType = t.OrderType,
                    TradeStatus = t.TradeStatus,
                    Quantity = t.Quantity,
                    ExecutionPrice = t.ExecutionPrice,
                    ExecutionDate = t.ExecutionDate,
                    ClosingPrice = t.ClosingPrice,
                    ClosingDate = t.ClosingDate,
                    StopLoss = t.StopLoss,
                    TakeProfit = t.TakeProfit,
                    ReasonForEntry = t.ReasonForEntry,
                    Swap = t.Swap,
                    Commissions = t.Commissions,
                    Notes = t.Notes,
                    Image = t.Image

                }).ToList();

            return trades;
        }

        public IEnumerable<TradesListModel> AllPendingTrades()
        {
            var trades = this.tradesDB.Trades
                .Where(t => t.TradeStatus.ToString() == "PendingOrder")
                .Select(t => new TradesListModel
                {
                    Id = t.Id,
                    OrderType = t.OrderType,
                    TradeStatus = t.TradeStatus,
                    Quantity = t.Quantity,
                    ExecutionPrice = t.ExecutionPrice,
                    ExecutionDate = t.ExecutionDate,
                    ClosingPrice = t.ClosingPrice,
                    ClosingDate = t.ClosingDate,
                    StopLoss = t.StopLoss,
                    TakeProfit = t.TakeProfit,
                    ReasonForEntry = t.ReasonForEntry,
                    Swap = t.Swap,
                    Commissions = t.Commissions,
                    Notes = t.Notes,
                    Image = t.Image

                }).ToList();

            return trades;
        }

        public TradeDetailsModel ShowDetails(string id)
        {
            var trade = this.tradesDB.Trades.Where(t => t.Id == id)
                .Select(t => new TradeDetailsModel
                {
                    Id = t.Id,
                    TradePair = t.TradePair,
                    OrderType = t.OrderType,
                    TradeStatus = t.TradeStatus,
                    Quantity = t.Quantity,
                    ExecutionPrice = t.ExecutionPrice,
                    ExecutionDate = t.ExecutionDate,
                    ClosingPrice = t.ClosingPrice,
                    ClosingDate = t.ClosingDate,
                    StopLoss = t.StopLoss,
                    TakeProfit = t.TakeProfit,
                    ReasonForEntry = t.ReasonForEntry,
                    Notes = t.Notes,
                    Commissions = t.Commissions,
                    Swap = t.Swap,
                    Image = t.Image
                }).FirstOrDefault();

            return trade;
        }

        public void AddTrade(TradedPair pair, OrderType orderType, TradeStatus status, double size, double? executionPrice, 
            DateTime? executionDate, double? closingPrice, DateTime? closingDate, double? stopLoss, double? takeProfit, 
            ReasonForEntry reason, double? swap, double? commissions, string notes, byte[]image)
        {
            var trade = new Trade
            {
                TradePair = pair,
                OrderType = orderType,
                TradeStatus = status,
                Quantity = size,
                ExecutionPrice = executionPrice,
                ExecutionDate = executionDate,
                ClosingPrice = closingPrice,
                ClosingDate = closingDate,
                StopLoss = stopLoss,
                TakeProfit = takeProfit,
                ReasonForEntry = reason,
                Swap = swap,
                Commissions = commissions,
                Notes = notes,
                Image = image
            };

            this.tradesDB.Trades.Add(trade);
            this.tradesDB.SaveChanges();
        }

        public bool Exists(string id) => this.tradesDB.Trades.Any(t => t.Id == id);
       

        public EditTradeModel FindTradeById(string id)
        {
            var trade = this.tradesDB.Trades.Where(t => t.Id == id)
                .Select(t => new EditTradeModel
                {
                    Id = t.Id,
                    TradePair = t.TradePair,
                    OrderType = t.OrderType,
                    TradeStatus = t.TradeStatus,
                    Quantity = t.Quantity,
                    ExecutionPrice = t.ExecutionPrice,
                    ExecutionDate = t.ExecutionDate,
                    ClosingPrice = t.ClosingPrice,
                    ClosingDate = t.ClosingDate,
                    StopLoss = t.StopLoss,
                    TakeProfit = t.TakeProfit,
                    ReasonForEntry = t.ReasonForEntry,
                    Notes = t.Notes, 
                    Image = t.Image

                }).SingleOrDefault();

            return trade;
        }

        public void EditTrade(string id, TradedPair pair, OrderType orderType, TradeStatus status, double size, double? executionPrice, DateTime? executionDate, 
            double? closingPrice, DateTime? closingDate, double? stopLoss, double? takeProfit, ReasonForEntry reason, double? swap, double? commissions, 
            string notes, byte[] image)
        {
            var trade = this.tradesDB.Trades.FirstOrDefault(t => t.Id == id);

            if (trade==null)
            {
                return;
            }

            trade.Id = id;
            trade.TradePair = pair;
            trade.OrderType = orderType;
            trade.TradeStatus = status;
            trade.Quantity = size;
            trade.ExecutionPrice = executionPrice;
            trade.ExecutionDate = executionDate;
            trade.ClosingPrice = closingPrice;
            trade.ClosingDate = closingDate;
            trade.StopLoss = stopLoss;
            trade.TakeProfit = takeProfit;
            trade.ReasonForEntry = reason;
            trade.Swap = swap;
            trade.Commissions = commissions;
            trade.Notes = notes;
            trade.Image = image;

            this.tradesDB.SaveChanges();
        }

        public void Delete(string id)
        {
            var trade = this.tradesDB.Trades.Find(id);

            if (trade==null)
            {
                return;
            }

            this.tradesDB.Trades.Remove(trade);
            this.tradesDB.SaveChanges();
        }

        public DeleteTradeModel FindTrade(string id)
        {
            var trade = this.tradesDB.Trades.Where(t => t.Id == id).Select(t => new DeleteTradeModel
            {
                Id = t.Id,
                TradePair = t.TradePair,
                OrderType = t.OrderType,
                TradeStatus = t.TradeStatus,
                Quantity = t.Quantity


            }).SingleOrDefault();

            return  trade;
        }
    }
    }

