using System.Collections.Generic;

namespace DevCar1_MVC.Controllers
{
    public class IndexModel
    {
        public List<Project> Projects { get; set; }
        public List<Article> Articles { get; set; }
    }
}