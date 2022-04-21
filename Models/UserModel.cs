using ServicePlugApi11.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicePlugApi11.Models
{
    public class UserModel
    {
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string user_email { get; set; }
        public string user_password { get; set; }
        public string user_contactdetails { get; set; }
        public int user_rating { get; set; }
        public string CardNumber { get; set; }

        public virtual BankingDetail BankingDetail { get; set; }
        public virtual Client Client { get; set; }

    }
}