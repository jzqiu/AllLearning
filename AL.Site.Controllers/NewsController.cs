using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AL.Site.Controllers
{
    public class NewsController:BaseController
    {
        public ActionResult Index(int id)
        {
            switch (id)
            {
                case 1:
                    ViewBag.Title = "教育动态";
                    break;
                case 2:
                    ViewBag.Title = "政策文件";
                    break;
                case 3:
                    ViewBag.Title = "图片新闻";
                    break;
                case 4:
                    ViewBag.Title = "通知公告";
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
