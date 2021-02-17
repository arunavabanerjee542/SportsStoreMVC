using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public interface ISportsRepository
    {
        IQueryable<Product> Products { get; }

    }
}
