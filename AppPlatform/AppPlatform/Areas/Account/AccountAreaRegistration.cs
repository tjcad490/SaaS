using System.Web.Mvc;

namespace AppPlatform.Areas.Account
{
    public class AccountAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Account";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Account_default",
                "Account/{action}/{id}",
                new { controller="Account",action = "LoginIndex", id = UrlParameter.Optional }
            );
        }
    }
}
