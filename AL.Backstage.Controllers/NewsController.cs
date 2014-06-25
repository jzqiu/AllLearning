using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AL.Backstage.Controllers
{
    public class NewsController:BaseController
    {
        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Policy()
        {
            return View();
        }
    }
}
