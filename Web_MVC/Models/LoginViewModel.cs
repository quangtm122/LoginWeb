using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_MVC.Models
{
    public class LoginViewModel
    {
       /* [Required]*/
        public string userName { get; set; }
       /* [Required]*/
        public string passWord { get; set; }
    }
}