﻿using System.Web;
using System.Web.Mvc;

namespace Redes_Sociales_4B
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
