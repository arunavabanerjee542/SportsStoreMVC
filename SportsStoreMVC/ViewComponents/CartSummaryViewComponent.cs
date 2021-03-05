using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartSummaryViewComponent(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }


    }
}
