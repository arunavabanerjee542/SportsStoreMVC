using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Infrastructure
{
    public static  class PathAndQueryExtention
    {
        public static string GetPathAndQuery(this HttpRequest request)
        {
            return request.QueryString.HasValue
                 ? $"{request.Path}{request.QueryString}"
                 : request.Path.ToString();
        }
                                             

    }
}
