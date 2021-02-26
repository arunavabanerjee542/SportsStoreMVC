﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public class Cart
    {
        public List<Item> MyCart = new List<Item>();

        public void AddToCart(Product product,int quantity)
        {
          var x =MyCart.Where(p=> p.Product.ProductID == product.ProductID).SingleOrDefault();

            if(x== null)
            {
                MyCart.Add(new Item() { Product = product, Quantity = quantity });
            }
            else
            {
               MyCart.
               Where(p => p.Product.ProductID == product.ProductID)
               .SingleOrDefault().Quantity++;
            }
        }


        public decimal CalculateTotalCost()
        {
           return  MyCart.Sum(p => p.Product.Price * p.Quantity);
        }

        public void Remove(Product product)
        {
                MyCart
                .RemoveAll(p => p.Product.ProductID == product.ProductID);
        }

        public bool DoesProductExists(int productId)
        {
            return MyCart
                   .Any(p => p.Product.ProductID == productId);
        }





    }
}