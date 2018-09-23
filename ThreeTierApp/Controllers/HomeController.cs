using Bussinesslogic;
using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThreeTierApp.Models;

namespace ThreeTierApp.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index(string search)
        //{
        //    var user = new UserBO();
        //    user.Name = search;
        //    user.address = search;

        //    var users = new UserBL().GetUserDetail(user);

        //    List<User> lstUser = new List<User>();

        //    foreach (var item in users)
        //    {
        //        lstUser.Add(new User()
        //        {
        //            Name = item.Name,
        //            address = item.address,
        //            EmailID = item.EmailID,
        //            Mobilenumber = item.Mobilenumber
        //        });
        //    }

        //    return View(lstUser);
        //}

        // GET: Home  
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(string Prefix)
        {
            var user = new UserBO();
            user.Name = Prefix;
            user.address = Prefix;

            var users = new UserBL().GetUserDetail(user);

            List<User> lstUser = new List<User>();

            foreach (var item in users)
            {
                lstUser.Add(new User()
                {
                    Name = item.Name + " - " + item.address
                });
            }
            
            return Json(lstUser, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetUser(string Prefix)
        {
            var user = new UserBO();
            user.Name = Prefix;
            user.address = Prefix;

            var users = new UserBL().GetUserDetail(user);

            List<User> lstUser = new List<User>();

            foreach (var item in users)
            {
                lstUser.Add(new User()
                {
                    Name = item.Name,
                    address = item.address,
                    EmailID = item.EmailID,
                    Mobilenumber = item.Mobilenumber
                });
            }

            return Json(lstUser, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Tabbing()
        {
            return View();
        }
    }
}