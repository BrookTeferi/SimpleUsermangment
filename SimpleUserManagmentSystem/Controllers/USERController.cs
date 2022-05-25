using SimpleUserManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Data;
using System.Data.SqlClient;

namespace SimpleUserManagmentSystem.Controllers
{
    public class USERController : Controller
    {
        private userEntities _userEntities = new userEntities();
       
        // GET: USER
        public ActionResult Index(string search_value, int? page, int? page_number)
        {


           
            int pagesize = 2;
            /*  var searched_value = _userEntities.USERS.Where(s => s.firstname == search_value);



              if (searched_value != null)
              {



                  return View(searched_value.ToList().ToPagedList(page_number ?? 1, 3));

              }

              else
              {
                  ViewBag.error = "Search not foundd";
                  return View();
              }



              var search_stored = _userEntities.USERS.ToList();
  */
           
            if (!String.IsNullOrEmpty(search_value))
            {


                var sw = _userEntities.USERS.Where( q => q.firstname.Contains(search_value));
               
                
                return View(sw.ToList().ToPagedList(page_number ?? 1, 3));

            }

            var search_stored = _userEntities.USERS.ToList();
            IPagedList<USER> users = null;
            int page_index = 1;
            page_index = page.HasValue ? Convert.ToInt32(page) : 1;
            var user_obj = _userEntities.USERS.ToList();
            users = user_obj.ToPagedList(page_index, pagesize);



            return View(users);
        }

        public JsonResult SearchName(string SearchBy,  string search_value)
        {
            List<USER> userlist = new List<USER>();
           
             var searched_value = _userEntities.USERS.Where(s => s.firstname.StartsWith(search_value) || search_value == null).ToList();

            return Json(searched_value, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        public JsonResult Searchfirstname(string firstname)
        {
           
            var us = from c in _userEntities.USERS
                            where c.firstname.Contains(firstname)
                            select c;
            return Json(us.ToList().Take(10));
        }
    




        public ActionResult searcher(string firstname)
        {
            USER user = new USER();
            DataSet dataSet = new DataSet();
            string constring = "Data Source=DESKTOP-2NDLJ4H; ;Initial Catalog=USERS;Integrated Security=SSPI;";
            SqlConnection sqlConnection = new SqlConnection(constring);
            string Pname = "Search First Name";
            sqlConnection.Open();
            SqlCommand com = new SqlCommand(Pname, sqlConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@firstname", ToString());
            SqlDataReader sqlData;
            sqlData = com.ExecuteReader();
            if (sqlData.Read())
            {
                ViewBag.searchResult = "First name has been found";
                user.firstname = firstname;
                user.lastname = sqlData["lastname"].ToString();
                user.lastname = sqlData["emailid"].ToString();
                user.lastname = sqlData["address"].ToString();
                user.lastname = sqlData["dateofbirth"].ToString();
            }
            sqlConnection.Close();


            return View(sqlData);
        }

    }


}


