using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryAppEmpty.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Save(TitleSubmitModel model)
        {
            return null;
        }

    }

    public class TitleSubmitModel
    {
        public string Title { get; set; }
    }
}
