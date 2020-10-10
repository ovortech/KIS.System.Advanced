using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.Support.Security
{
    public static class SessionPersister
    {
        private static string UserSession = "user";       
            
        public static CustomPrincipal User
        {
            get
            {
                if (HttpContext.Current == null)
                    return null;
                var sessionVar = HttpContext.Current.Session[UserSession];
                if (sessionVar != null)
                    return sessionVar as CustomPrincipal;
                return null;
            }
            set
            {
                HttpContext.Current.Session[UserSession] = value;
            }
        }
        public static void Deslogar()
        {
            HttpContext.Current.Session.RemoveAll();
        }
        /*
        public static string UserName
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;
                var sessionVar = HttpContext.Current.Session[UserNameSession];
                if (sessionVar != null)
                    return sessionVar as string;
                return null;
            }
            set
            {
                HttpContext.Current.Session[UserNameSession] = value;
            }
        }
        */
    }
}