using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AL.Site.Controllers
{
    public class AccountController:BaseController
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}
