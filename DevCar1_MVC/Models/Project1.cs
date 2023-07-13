using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCar1_MVC.Models
{
    public class Project1
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project1(long id, string name, string discription, string image, string client)
        {
            Id = id;
            Name = name;
            Discription = discription;
            Image = image;
            Client = client;
        }
    }
}
