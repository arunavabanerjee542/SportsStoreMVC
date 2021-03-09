using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;
        private Cart _cart;
        public OrderController(IOrderRepository orderRepository, Cart cart)
        {
            _orderRepository = orderRepository;
            _cart = cart;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Checkout() => View( new Order());

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (_cart.MyCart.Count() == 0)
                ModelState.AddModelError("", " NO ITEMS IN CART ");

            if(ModelState.IsValid)
            {
                order.Lines = _cart.MyCart.ToList();
                _orderRepository.SaveOrder(order);
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            return View();
        }
    }
}
