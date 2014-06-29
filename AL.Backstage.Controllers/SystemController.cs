using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AL.Backstage.Controllers
{
    public class SystemController:BaseController
    {
        public ActionResult MUser()
        {
            return View();
        }

        public ActionResult MEditor()
        {
            return View();
        }

        public ActionResult LoginLog()
        {
            return View();
        }

        public ActionResult OprationLog()
        {
            return View();
        }
    }
}
