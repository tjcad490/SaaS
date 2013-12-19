using System.Web.Mvc;

namespace AppPlatform.Areas.EnterpriseUser
{
    public class EnterpriseUserAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "EnterpriseUser";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "EnterpriseUser_default",
                "EnterpriseUser/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
