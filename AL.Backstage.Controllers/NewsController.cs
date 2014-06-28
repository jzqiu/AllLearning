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

        public ActionResult NImage()
        {
            return View();
        }

        public ActionResult Report()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Submit(FormCollection form)
        {
            var content = form["editorValue"];
            return Json(new { status = 200 });
        }
    }
}
