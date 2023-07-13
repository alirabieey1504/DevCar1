using System.Collections.Generic;


namespace DevCar1_MVC.Models
{
    public class Article1
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string Image { get; set; }

        public Article1(long id, string title, string discription, string image)
        {
            Id = id;
            Title = title;
            Discription = discription;
            Image = image;
        }

    }
}