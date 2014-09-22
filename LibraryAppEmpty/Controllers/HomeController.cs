using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Data;

//using Library.Data;

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
            var book = new Book();
            book.Title = model.Title;
            var libraryContext = new LibraryData();
            libraryContext.Books.Add(book);
            libraryContext.SaveChanges();  
            return new JsonResult(){Data = ""};
        }

    }

    public class TitleSubmitModel
    {
        public string Title { get; set; }
    }
}
