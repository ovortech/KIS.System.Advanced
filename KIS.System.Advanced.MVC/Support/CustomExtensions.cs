using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.Support
{
    public static class CustomExtensions
    {
        public static List<string> ToListFlag(this Enum enumFlags)
        {         
            List<string> result = new List<string>();
            foreach (var item in Enum.GetValues(enumFlags.GetType()))
            {
                //Enum.Parse(enumFlags.GetType(), item.ToString(), true)
                // if ((enumFlags.GetType() enumFlags & item) != 0) result.Add(item.ToString());
            }
            return result;
        }
    }
}