﻿using System.Web;
using System.Web.Mvc;

namespace CVSite_Grupp19
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}