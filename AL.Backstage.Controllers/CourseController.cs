using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AL.Backstage.Controllers
{
    public class CourseController:BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Courseware()
        {
            return View();
        }

        //<form action="/home/uploadfiles" method="post" enctype="multipart/form-data">
        //    <label for="file">Filename:</label>
        //    <input type="file" name="file" id="file" />
 
        //    <input type="submit" name="submit" value="Submit" />
        //</form>

        public ActionResult UploadFiles()
        {
            foreach (string file in Request.Files)
            {
                HttpPostedFileBase hpf = Request.Files[file] as HttpPostedFileBase;
                if (hpf.ContentLength == 0)
                    continue;
                string savedFileName = Path.Combine(
                   AppDomain.CurrentDomain.BaseDirectory,
                   Path.GetFileName(hpf.FileName));
                hpf.SaveAs(savedFileName);
            }
            return View("UploadedFiles");
        }
    }
}
