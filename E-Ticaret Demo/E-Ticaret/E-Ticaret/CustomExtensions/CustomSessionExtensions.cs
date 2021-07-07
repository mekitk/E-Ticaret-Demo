using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.CustomExtensions
{
    public static class CustomSessionExtensions
    {
        public  static void SetObject<T>(this ISession session,string key, T value) where
            T:class, new()
        {
            var stringdata= JsonConvert.SerializeObject(value);
            session.SetString(key,stringdata);
        }

        public static T GetObject<T>(this ISession session, string key)where T:class,new()
        {
            var jsondata = session.GetString(key);
            if (!string.IsNullOrWhiteSpace(jsondata))
            {
             JsonConvert.DeserializeObject<T>(jsondata);
            }
            return null;

        }
    }
}
