using Library.Business;
using Library.Domain;
using System.Web.Mvc;

namespace LibraryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILibraryService _libraryService;

        public HomeController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Save(BookSubmitModel model)
        {
            _libraryService.CreateBook(model);
            return new JsonResult(){Data = ""};
        }

    }    
}
