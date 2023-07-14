using System;
using DevCar1_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace DevCar1_MVC.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
           
        }

        public ViewResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        [HttpGet]
        public IActionResult Contact()
        {
            var model=new Contact();
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده  صحیح نیست";
                return View(model);
            }

            ViewBag.success = "پیغام شما با موفقیت ارسال شد با تشکر";
            return View();
            // return RedirectToAction("Index");
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
