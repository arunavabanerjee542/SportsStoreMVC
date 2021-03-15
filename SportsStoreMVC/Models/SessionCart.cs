using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SportsStoreMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession Session { get; set; }


        public static Cart GetCart(IServiceProvider provider)
        {
           ISession session =  provider.GetRequiredService<IHttpContextAccessor>()
                ?.HttpContext.Session;

            var cart = session.GetJsonObj<SessionCart>("cart")
                         ?? new SessionCart();

            cart.Session = session;

            return cart;

        }

        public override void AddToCart(Product product, int quantity)
        {
            base.AddToCart(product, quantity);
            Session.SetJsonObj("cart", this);
        }

        public override void Remove(Product product)
        {
            base.Remove(product);
            Session.SetJsonObj("cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("cart");
        }

    }



}

