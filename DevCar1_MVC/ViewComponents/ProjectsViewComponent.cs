using System.Collections.Generic;
using System.Linq;
using DevCar1_MVC.Controllers;
using DevCar1_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCar1_MVC.ViewComponents
{
    public class ProjectsViewComponent  :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project1>()
            {
                new Project1(id:1,name:"تاکسی",discription:"پروژه تاکسی رانی های مختلف در بازار ", image:"project-1.jpg",client:"snap"),
                new Project1(id:2,name:"زود فود",discription:"درخواست انلاین غذا ",image:"project-2.jpg", client:"zoodfood"),
                new Project1(id:3,name:"Mobile",discription:"پروژه تعمیر و سفارش انواع تلفن همراه ",image:"project-3.jpg", client:"mobile"),
                new Project1(id:4,name:"مداری",discription:"سیستم مدیریت یکپارچه مدارس ",image:"project-7.jpg", client:"madares"),

            };
            return View("_Projects",Projects);
        }
    }
}
