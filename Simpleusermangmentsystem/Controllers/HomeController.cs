using Simpleusermangmentsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simpleusermangmentsystem.Controllers
{
    public class HomeController : Controller
    {
        private userEntities _userEntities = new userEntities();
        
        public ActionResult Index()
        {
            ViewBag.Message = false;
            return View();
        }
        [HttpPost]
        public JsonResult Searchfirstname(string search_value)
        {
            List<USER> userlist = new List<USER>();

            var searched_value = _userEntities.USERS.Where(s => s.firstname.StartsWith(search_value) || search_value == null).ToList();

            return Json(searched_value, JsonRequestBehavior.AllowGet);

                }
    }
}
