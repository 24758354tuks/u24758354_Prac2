﻿using System.Web;
using System.Web.Mvc;

namespace u24758354_Prac2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
