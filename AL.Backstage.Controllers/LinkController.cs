using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AL.Backstage.Controllers
{
    public class LinkController:BaseController
    {
        public ActionResult Index(int id)
        {
            switch (id)
            {
                case 1:
                    ViewBag.Title = "电子期刊";
                    break;
                case 2:
                    ViewBag.Title = "图书馆";
                    break;
                case 3:
                    ViewBag.Title = "底部链接";
                    break;
            }
            return View();
        }
    }
}
