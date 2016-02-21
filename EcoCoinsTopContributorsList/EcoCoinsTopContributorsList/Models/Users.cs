using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoCoinsTopContributorsList.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string RegDate { get; set; }
    }
}