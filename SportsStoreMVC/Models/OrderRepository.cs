using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public class OrderRepository : IOrderRepository
    {
        public SportsStoreDb _context;
        public OrderRepository(SportsStoreDb sportsStoreDb)
        {
            _context = sportsStoreDb;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return null;
        }

        public void SaveOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
