
using System;
using System.Collections.Generic;
using System.Xml;
using DevCar1_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;

namespace DevCar1_MVC.ViewComponents
{
    public class LatestArticleViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            var articles = new List<Article1>()
            {
                new Article1(id:1,title:"اموزش asp.net core 5",discription:"اموزش همراه با رفع اشکال و 3 پروژه انلاین",image:"blog-post-thumb-card-1.jpg"),
                new Article1(id:2,title:"اموزش gitوgithub",discription:"اموزش کاملا پروژه محور",image:"blog-post-thumb-card-2.jpg"),
                new Article1(id:3,title:"اموزش htmlوcss",discription:"اموزش همراه با ارایه مدرک بین المللی",image:"blog-post-thumb-card-3.jpg"),
                new Article1(id:4,title:"اموزش java script",discription:"اموزش های رسمی توسط مدرس رسمی ماکرو سافت",image:"blog-post-thumb-card-4.jpg"),

            };
            return View("LatestsArticles", articles);



        }


    }

    
    
}
