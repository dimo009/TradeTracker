

namespace TradeTracker.WEB.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TradeTracker.SERVICES.Contracts;
    using TradeTracker.WEB.Models;

    [Route("trades")]
    public class TradeController : Controller
    {
        private readonly ITradeService tradeService;

        public TradeController(ITradeService tradeService)
        {
            this.tradeService = tradeService;
        }

        [HttpGet]
        [Route(nameof(AllTrades))]
        public IActionResult AllTrades()
        {
            return View(new TradesListViewModel
            {
                AllTrades = this.tradeService.AllTrades()
            });
        }

        [HttpGet]
        [Route(nameof(Details))]
        public IActionResult Details(string id)
        {
            var trade = this.tradeService.ShowDetails(id);

            if (trade == null)
            {
                return NotFound();
            }

            return View(new TradeDetailsViewModel
            {
                Id = trade.Id,
                TradePair = trade.TradePair,
                OrderType = trade.OrderType,
                TradeStatus = trade.TradeStatus,
                Quantity = trade.Quantity,
                ExecutionPrice = trade.ExecutionPrice,
                ExecutionDate = trade.ExecutionDate,
                ClosingPrice = trade.ClosingPrice,
                ClosingDate = trade.ClosingDate,
                StopLoss = trade.StopLoss,
                TakeProfit = trade.TakeProfit,
                ReasonForEntry = trade.ReasonForEntry,
                Notes = trade.Notes,
                Swap = trade.Swap,
                Commissions = trade.Commissions,
                Image = trade.Image
            });
        }


        [HttpGet]
        [Route(nameof(AddTrade))]
        public IActionResult AddTrade() => View();

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [Route(nameof(AddTrade))]
        public IActionResult AddTrade(AddTradeViewModel tradeModel)
        {
            if (!ModelState.IsValid)
            {
                return View(tradeModel);
            }

            this.tradeService.AddTrade(tradeModel.TradePair, tradeModel.OrderType, tradeModel.TradeStatus, tradeModel.Quantity, tradeModel.ExecutionPrice,
                tradeModel.ExecutionDate, tradeModel.ClosingPrice, tradeModel.ClosingDate, tradeModel.StopLoss, tradeModel.TakeProfit, tradeModel.ReasonForEntry,
                tradeModel.Swap, tradeModel.Commissions, tradeModel.Notes, tradeModel.Image);

            return this.RedirectToAction(nameof(AllTrades));
        }

        [HttpGet]
        [Route(nameof(EditTrade) + "/id")]
        public IActionResult EditTrade(string id)
        {
            var trade = this.tradeService.FindTradeById(id);

            if (trade==null)
            {
                return NotFound();
            }

            return View(new EditTradeViewModel
            {
                Id = trade.Id,
                TradePair = trade.TradePair,
                OrderType = trade.OrderType,
                TradeStatus = trade.TradeStatus,
                Quantity = trade.Quantity,
                ExecutionPrice = trade.ExecutionPrice,
                ExecutionDate = trade.ExecutionDate,
                ClosingPrice = trade.ClosingPrice,
                ClosingDate = trade.ClosingDate,
                StopLoss = trade.StopLoss,
                TakeProfit = trade.TakeProfit,
                ReasonForEntry = trade.ReasonForEntry,
                Notes = trade.Notes,
                Swap = trade.Swap,
                Commissions = trade.Commissions,
                Image = trade.Image
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route(nameof(EditTrade) + "/id")]
        public IActionResult EditTrade(string id, EditTradeViewModel tradeModel)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var tradeExists = this.tradeService.Exists(id);

            if (!tradeExists)
            {
                return NotFound();
            }

            this.tradeService.EditTrade(tradeModel.Id, tradeModel.TradePair, tradeModel.OrderType, tradeModel.TradeStatus, tradeModel.Quantity, tradeModel.ExecutionPrice,
                tradeModel.ExecutionDate, tradeModel.ClosingPrice, tradeModel.ClosingDate, tradeModel.StopLoss, tradeModel.TakeProfit, tradeModel.ReasonForEntry,
                tradeModel.Swap, tradeModel.Commissions, tradeModel.Notes, tradeModel.Image);

            return RedirectToAction(nameof(AllTrades));
        }


        //[Route(nameof(DeleteTrade)+"/id")]
        //public IActionResult DeleteTrade(string id)
        //{
        //    return View(nameof(DeleteTrade));
        //}

        //[HttpPost]
        //[Route(nameof(DestroyTrade) + "/id")]
        //public IActionResult DestroyTrade(string id)
        //{
        //    this.tradeService.Delete(id);

        //    return RedirectToAction(nameof(AllTrades));
        //}

        [HttpGet]
        [Route(nameof(DeleteTrade)+"/id")]
        public IActionResult DeleteTrade(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trade = this.tradeService.FindTrade(id);
            if (trade == null)
            {
                return NotFound();
            }



            return View(new DeleteTradeViewModel
            {

                Id = trade.Id,
                TradePair = trade.TradePair,
                OrderType = trade.OrderType,
                TradeStatus = trade.TradeStatus,
                Quantity = trade.Quantity

            });
        }

        [HttpPost]
        [Route(nameof(DeleteConfirmed)+"/id")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
           
            this.tradeService.Delete(id);

            return RedirectToAction(nameof(AllTrades));
        }
    }
}
