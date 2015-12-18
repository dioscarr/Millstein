using System.Web.Mvc;

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
                "AdminLogin",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Account", action = "login", id = UrlParameter.Optional }
            );

           

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new string[] { "MilllsteinG1.Areas.Admin.Controllers" }
            );


            context.MapRoute(
               "AdminNews",
               "Admin/{controller}/{action}/{id}",
               new { controller = "News", action = "Index", id = UrlParameter.Optional }, new string[] { "MilllsteinG1.Areas.Admin.Controllers" }
           );
        }
    }
}