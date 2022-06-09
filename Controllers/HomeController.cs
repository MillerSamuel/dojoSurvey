using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey.Controllers;     
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }


        [HttpPost("process")]
        public IActionResult Process(User newUser)
        {
            if(ModelState.IsValid)
            {
            return RedirectToAction("result",newUser);
            }
            else
            {
                return View("index");
            }
        }

        [HttpGet("result")]
        public ViewResult Result(User newUser)
        {
            ViewBag.User=newUser;
            return View("Result");
        }
    }