using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab21.Models
{
    public class UserInfo
    {
        [Required]
        public string UserName { set; get; }
        [Required]
        public string Password { set; get; }
        [Required]
        [RegularExpression(@"/^[a-zA-Z0-9]{5,30}@[a-zA-Z]{5,10}\.[a-zA-Z0-9]{2,3}$",ErrorMessage ="Invalid Email Format")]
        public string Eamil { set; get; }

        public UserInfo(string userName,string password,string eamil)
        {
            UserName = userName;
            Password = password;
            Eamil = eamil;
        }

        public UserInfo()
        {
        }



    }
}