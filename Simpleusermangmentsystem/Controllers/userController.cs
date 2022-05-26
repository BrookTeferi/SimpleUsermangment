using Simpleusermangmentsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Simpleusermangmentsystem.Controllers
{
    public class userController : ApiController
    {
        private userEntities _userEntities = new userEntities();

        public IHttpActionResult GetUser(string fname)
        {
            var firstname = _userEntities.USERS.FirstOrDefault(s=> s.firstname== fname);
            if (firstname == null)
            {
                return NotFound();
            }
            return Ok(firstname);
        }
    }
}