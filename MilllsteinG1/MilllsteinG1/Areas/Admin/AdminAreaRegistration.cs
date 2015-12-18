﻿using System.Web.Mvc;

namespace MilllsteinG1.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

            context.MapRoute(
                  name: "loginoff",
                  url: "Account/loginOff",
                  defaults: new { controller = "Account", action = "LoingOff", id = UrlParameter.Optional });
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}