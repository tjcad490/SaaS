using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppPlatform.Areas.Account.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/Account/

        public ActionResult LoginIndex()
        {
            return View();
        }

    }
}
