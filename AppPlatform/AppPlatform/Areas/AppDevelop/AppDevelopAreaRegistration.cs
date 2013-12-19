using System.Web.Mvc;

namespace AppPlatform.Areas.AppDevelop
{
    public class AppDevelopAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AppDevelop";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AppDevelop_default",
                "AppDevelop/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
