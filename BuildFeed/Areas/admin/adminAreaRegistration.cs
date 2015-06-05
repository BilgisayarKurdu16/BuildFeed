﻿using System.Web.Mvc;

namespace BuildFeed.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Meta",
                "admin/{controller}/{action}/{type}/{value}",
                new { action = "index", controller = "meta" }
            );

            context.MapRoute(
                "Admin (Default)",
                "admin/{controller}/{action}/{id}",
                new { action = "index", controller = "base", id = UrlParameter.Optional }
            );
        }
    }
}