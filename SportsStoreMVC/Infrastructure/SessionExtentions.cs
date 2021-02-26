using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SportsStoreMVC.Infrastructure
{
    public static class SessionExtentions
    {
        public static void SetJsonObj(this ISession session, string key, object value)
        {
            session.SetString(key,
                JsonSerializer.Serialize(value));
        }

        public static T GetJsonObj<T>(this ISession session,string key)
        {
            var data = session.GetString(key);
            return data == null ? default(T) : JsonSerializer.Deserialize<T>(data);

        }

    }
}
