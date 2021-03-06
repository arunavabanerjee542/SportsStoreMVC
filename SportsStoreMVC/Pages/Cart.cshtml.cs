using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStoreMVC.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStoreMVC.Models;

namespace SportsStoreMVC.Pages
{
    public class CartModel : PageModel
    {
        private ISportsRepository _sportsRepository;
        public CartModel(ISportsRepository sportsRepository , Cart cart)
        {
            _sportsRepository = sportsRepository;
            Cart = cart;
        }

        public string MyUrl { get; set; }
        public Cart Cart { get; set; }


        public void OnGet(string myUrl)
        {
            MyUrl = myUrl ?? "/";
            /*
            Cart = HttpContext.Session.GetJsonObj<Cart>("cart") ??
            new Cart();
            */

        }

        public IActionResult OnPost(int ProductId , string myUrl)
        {
            /*
            Cart = 
                HttpContext.Session.GetJsonObj<Cart>("cart");
            */

            var product = _sportsRepository.Products
                             .Where(p => p.ProductID == ProductId)
                             .SingleOrDefault();

            Cart.AddToCart(product, 1);

/*
            if (Cart != null)
            {
                Cart.AddToCart(product, 1);
                HttpContext.Session.SetJsonObj("cart", Cart);
            }

            else
            {
                Cart = new Cart();
                Cart.AddToCart(product, 1);
                HttpContext.Session.SetJsonObj("cart", Cart);
            }
*/

            return RedirectToPage(new { MyUrl = myUrl });

        }


        public IActionResult OnPostRemove(int ProductId , string myUrl)
        {
            Cart.Remove(Cart
                       .MyCart
                       .First(p => p.Product.ProductID == ProductId)
                       .Product);

            return RedirectToPage(new { myUrl = myUrl });
            

        }








    }
}
