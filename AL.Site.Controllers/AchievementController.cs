using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AL.Site.Controllers
{
    public class AchievementController:BaseController
    {
        public ActionResult Index(int id)
        {
            switch (id)
            {
                case 1:
                    ViewBag.Title = "主题教育";
                    break;
                case 2:
                    ViewBag.Title = "社区活动";
                    break;
                case 3:
                    ViewBag.Title = "学习型组织建设";
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
