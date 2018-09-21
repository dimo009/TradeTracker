using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TradeTracker.DATA.Enums;

namespace TradeTracker.DATA.Models
{
    public class Trade
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [Column("Traded pair")]
        public TradedPair TradePair { get; set; } 

        [Required]
        [Column("Order type")]
        public OrderType OrderType { get; set; }

        [Required]
        [Column("Trade status")]
        public TradeStatus TradeStatus { get; set; }

        [Required]
        [Range(0.01,10000)]
        public double Quantity { get; set; }

        
        [Range(0.00,10000)]
        [Column("Price of execution")]
        public double? ExecutionPrice { get; set;}

       
        [Column("Execution date")]
        public DateTime? ExecutionDate { get; set; }

       
       
        [Column("Price of closing")]
        public double? ClosingPrice { get; set; }

        
        [Column("Close date")]
        public DateTime? ClosingDate { get; set; }

        [Column("Stop/Loss")]
        public double? StopLoss { get; set; }

        [Column("Take/Profit")]
        public double? TakeProfit { get; set; }

        public double? Swap { get; set; }

        public double? Commissions { get; set; }

        [Required]
        [Column("Entry reason")]
        public ReasonForEntry ReasonForEntry { get; set; }

        public string Notes { get; set; }

        public byte[] Image { get; set; }

    }
}
