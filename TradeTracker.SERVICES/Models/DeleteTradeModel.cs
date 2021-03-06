﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TradeTracker.DATA.Enums;

namespace TradeTracker.SERVICES.Models
{
    public class DeleteTradeModel
    {
        public string Id { get; set; }

        [Required]
        public TradedPair TradePair { get; set; }

        [Required]
        [Column("Order type")]
        public OrderType OrderType { get; set; }

        [Required]
        [Column("Trade status")]
        public TradeStatus TradeStatus { get; set; }

        [Required]
        [Range(0.01, 10000)]
        public double Quantity { get; set; }
    }
}
