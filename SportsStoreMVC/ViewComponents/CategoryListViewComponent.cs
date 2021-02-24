using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ISportsRepository _sportsRepository;

        public CategoryListViewComponent(ISportsRepository sportsStore)
        {
            _sportsRepository = sportsStore;
        }


        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_sportsRepository
                .Products
                .Select(p => p.Category)
                .Distinct());
        }


    }
}
