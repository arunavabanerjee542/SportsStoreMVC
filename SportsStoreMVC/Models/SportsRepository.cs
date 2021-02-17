using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public class SportsRepository : ISportsRepository
    {
        private SportsStoreDb _context;
        public SportsRepository(SportsStoreDb context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;
    }
}
