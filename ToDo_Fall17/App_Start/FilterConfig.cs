﻿using System.Web;
using System.Web.Mvc;

namespace ToDo_Fall17
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
