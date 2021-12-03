using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey{
    
    public class FirstController : Controller
    {
        public static string yName;

        public static string dLocation;

        public static string fLanguage;

        public static string cmnt;

        [HttpGet]
        [Route("")]

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("process")]

        public IActionResult Process(string yourName, string dojoLocation, string favoriteLanguage, string comment)
        {
            yName = yourName;
            dLocation = dojoLocation;
            fLanguage = favoriteLanguage;
            cmnt = comment;
            return RedirectToAction("Result");
        }

        [HttpGet]
        [Route("Process")]

        public IActionResult Result()
        {
            ViewBag.YourName = yName;
            ViewBag.DojoLocation = dLocation;
            ViewBag.FavoriteLanguage = fLanguage;
            ViewBag.Comment = cmnt;
            return View("Result");
        }
    }
}