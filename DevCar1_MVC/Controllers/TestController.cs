using System;
using System.Net;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Razor;

namespace DevCar1_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public PartialViewResult index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //  //  return Content("<h1>heloo word content result <h1>");
        //    return Content($"<h1 style='color='red''>heloo word content result </h1><script>confirm('این سوال من است ')</script>",contentType:"text/html");
        //}

        //public EmptyResult index()
        //{
        //  //  return new EmptyResult();
        //    return null;
        //}

        //public FileResult Index()
        //{
        //    //return File("~/test.txt", contentType:"text/html"); 
        //    var FileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string filename = "testFile.txt";
        //    return File(FileByte, MediaTypeNames.Text.Plain, filename);
        //}

        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 12,
        //        name = "ali",
        //        job = "programmer",
        //        site = "Alirabiee.com"
        //    });
        //}

        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('salam be hame')");
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("https://github.com");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}

        public IActionResult Index()
        {
            //return new OkResult();
            //return new ConflictResult();
            //  return new NotFoundResult();
           // return new BadRequestResult();
          // return  new NoContentResult();

          return  new StatusCodeResult(401);
        }
    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";

    //    }
    //}
}