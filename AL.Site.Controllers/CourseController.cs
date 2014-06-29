using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AL.Site.Controllers
{
    public class CourseController:BaseController
    {
        public ActionResult Index(int id)
        {
            switch (id)
            {
                case 1:
                    ViewBag.Title = "精品课程";
                    break;
                case 2:
                    ViewBag.Title = "热门课程";
                    break;
                case 3:
                    ViewBag.Title = "最新课程";
                    break;
                case 4:
                    ViewBag.Title = "全部课程";
                    break;
            }
            return View();
        }

        public ActionResult Content(int id)
        {
            return View();
        }
    }
}
