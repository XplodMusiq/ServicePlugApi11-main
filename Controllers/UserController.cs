using ServicePlugApi11.DataAccess;
using ServicePlugApi11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicePlugApi11.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        ServicePlugEntities db = new ServicePlugEntities();

        [HttpPost]
        [Route("register")]
        public IHttpActionResult registerClient([FromBody] UserModel user )
        {
            var user_db = db.Users.Where(u => u.user_email == user.user_email).FirstOrDefault();

            if(user_db != null)
            {
                return BadRequest("User already existed");
            }
            else
            {
           
                user_db = new User
                {
                    user_name = user.user_name,
                    user_id = user.user_id,
                    user_email = user.user_email,
                    user_password = user.user_password,
                    user_surname = user.user_surname,
                    user_contactdetails = user.user_contactdetails,
                    user_rating = user.user_rating,
                    BankingDetail = user.BankingDetail,
                   CardNumber = user.CardNumber,
                    Client = user.Client

                 

                };
            

                db.Users.Add(user_db);
                db.SaveChanges();
                return Ok("success");
            }

            return Ok("You are registered ");
        }
         
    }
}
