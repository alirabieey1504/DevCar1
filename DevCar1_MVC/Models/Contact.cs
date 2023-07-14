using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCar1_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حد اقل طول نام 3 کاراکتر است")]
        [MaxLength(100, ErrorMessage = "حد اکثر طول نام 100 کاراکتر است")]

        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]

        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمل صحیح نیست")]
        public string Email { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Message { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Service { get; set; }
    }
}
