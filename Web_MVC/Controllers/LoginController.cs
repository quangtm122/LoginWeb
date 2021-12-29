using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_MVC.Models;

namespace Web_MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        IAccountModel _accountModel;

        public IAccountModel accountModel { get { return _accountModel ?? (_accountModel = new AccountModel()); } private set { } }

        public ActionResult Index()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]

        public ActionResult Login(LoginViewModel obj)
        {
            if(ModelState.IsValid)
            {
                var res = accountModel.CheckLogin(obj.userName, obj.passWord);
                if(res != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Thông tin tài khoản hoặc mật không chính xác");
                }

            }
            return View("Index");
        }
    }
}