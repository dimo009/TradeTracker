

namespace TradeTracker.DATA.Context
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TradeTracker.DATA.Models;

    public class TradeDbContext: DbContext
    {
        public virtual DbSet <Trade> Trades { get; set; }

        public TradeDbContext(DbContextOptions<TradeDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Trade>()
                .HasKey(t => t.Id);

            builder.Entity<Trade>()
               .HasData(
               new Trade
               {
                   Id = "1",
                   TradePair = Enums.TradedPair.EURUSD,
                   OrderType = Enums.OrderType.BuyMarket,
                   TradeStatus = Enums.TradeStatus.Open,
                   Quantity = 1.00,
                   ExecutionPrice = 1.16800,
                   ExecutionDate = new DateTime(2018, 09, 13),
                   TakeProfit = 1.18000,
                   StopLoss = 1.16000,
                   Swap = 0.00,
                   Commissions = 0.00,
                   ReasonForEntry = Enums.ReasonForEntry.ContractingFlat,
                   Notes = "Market enter after US CPI data release. Do not hold overnight!!!"



               });

            builder.Entity<Trade>()
            .HasData(
            new Trade
            {
                Id = "2",
                TradePair = Enums.TradedPair.EURGBP,
                OrderType = Enums.OrderType.SellLimit,
                TradeStatus = Enums.TradeStatus.PendingOrder,
                Quantity = 1.00,
                ExecutionPrice = 0.90800,
                ExecutionDate = new DateTime(2018, 09, 13),
                TakeProfit = 0.8812,
                StopLoss = 0.91300,
                Swap = 0.00,
                Commissions = 0.00,
                ReasonForEntry = Enums.ReasonForEntry.ResistanceArea,
                Notes = "Long term trade"



            });

            builder.Entity<Trade>()
              .HasData(
              new Trade
              {
                  Id = "3",
                  TradePair = Enums.TradedPair.EURNZD,
                  OrderType = Enums.OrderType.BuyMarket,
                  TradeStatus = Enums.TradeStatus.Closed,
                  Quantity = 5.00,
                  ExecutionPrice = 1.7710,
                  ExecutionDate = new DateTime(2018, 09, 17),
                  ClosingPrice = 1.7790,
                  ClosingDate = new DateTime(2018, 09, 18, 09, 15, 00),
                  TakeProfit = 1.7790,
                  StopLoss = 1.7690,
                  Swap = -0.10,
                  Commissions = 0.00,
                  ReasonForEntry = Enums.ReasonForEntry.BatBullish,
                  Notes = "Scalping. Following the news feeds and expectations for euro consolidation. Time horizon is less than 12 hours"



              });

        }

    }
}
