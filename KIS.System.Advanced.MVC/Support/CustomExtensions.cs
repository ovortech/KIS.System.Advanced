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

        public static DateTime ParseDateTimeBrToUs(this String data)
        {
            int dtDia, dtMes, dtAno;
            dtDia = Convert.ToInt32(data.Split('/')[0]);
            dtMes = Convert.ToInt32(data.Split('/')[1]);
            dtAno = Convert.ToInt32(data.Split('/')[2]);
            DateTime dt = new DateTime(dtAno, dtMes, dtDia);
            return dt;
        }

        public static String ParseDateTimeToBr(this DateTime data)
        {
            String dt = string.Format("{0}/{1}/{2}", data.Day, data.Month, data.Year);
            return dt;
        }
    }
}