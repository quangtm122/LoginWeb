using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_MVC.Models
{
    public class AccountModel : IAccountModel
    {
        public User CheckLogin(string userName, string passWord)
        {
            using (var db = new LoginEntities())
            {
                return db.Users.Where(x => x.userName == userName && x.passWord == passWord).FirstOrDefault();
            }
        }
    }
}