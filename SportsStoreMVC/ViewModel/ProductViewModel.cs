using SportsStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.ViewModel
{
    public class ProductViewModel
    {
        public IQueryable<Product> Products { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
