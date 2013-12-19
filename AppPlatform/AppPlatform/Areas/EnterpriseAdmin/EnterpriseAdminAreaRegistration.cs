using System.Web.Mvc;

namespace AppPlatform.Areas.EnterpriseAdmin
{
    public class EnterpriseAdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "EnterpriseAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "EnterpriseAdmin_default",
                "EnterpriseAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
