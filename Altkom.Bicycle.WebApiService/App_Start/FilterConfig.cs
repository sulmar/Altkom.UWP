﻿using System.Web;
using System.Web.Mvc;

namespace Altkom.Bicycle.WebApiService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
