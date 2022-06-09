using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;     
    public class HomeController : Controller
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public ViewResult Index()
        {
            return View("index");
        }


        [HttpPost("result")]
        public IActionResult Result(string Name, string Location, string Fav, string Comment)
        {
            ViewBag.Name=Name;
            ViewBag.Location=Location;
            ViewBag.Fav=Fav;
            ViewBag.Comment=Comment;
            return View("Result");
        }
    }