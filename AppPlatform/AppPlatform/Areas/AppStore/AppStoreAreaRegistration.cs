using System.Web.Mvc;

namespace AppPlatform.Areas.AppStore
{
    public class AppStoreAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AppStore";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AppStore_default",
                "AppStore/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
