using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsStoreMVC.Models;
using SportsStoreMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        private ISportsRepository _sportsRepository;
        public HomeController(ISportsRepository sportsRepository)
        {
            //_logger = logger;
            _sportsRepository = sportsRepository;
        }

        public  int _pageSize = 3;
        public ViewResult Index(string category,int pagesize =1)
        {
            IQueryable<Product> products = _sportsRepository.Products
                .Where(p=> p.Category == null || p.Category == category)
                .Skip((pagesize - 1) * _pageSize).Take(_pageSize);
            return View(new ProductViewModel()
            {
                Products = products,
                PageInfo = new PageInfo()
                {
                    CurrentPage = pagesize,
                    ItemsPerPage = _pageSize,
                    TotalItems = _sportsRepository.Products.Count()
                },
                CurrentCategory = category

            }) ;
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
