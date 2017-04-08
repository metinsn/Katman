using Katman.DAL;
using Katman.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Katman.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var result = Repository.GetAllUser();
            return View(result);
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            Repository.UserAdd(user);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteUser(int id)
        {
            Repository.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}