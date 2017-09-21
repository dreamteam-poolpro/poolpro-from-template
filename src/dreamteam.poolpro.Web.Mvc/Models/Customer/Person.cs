using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Person
    {
        // first name
        public string FirstName { get; set; }

        // last name
        public string LastName { get; set; }

        // phone number, maybe this should be a list?
        public string PhoneNumber { get; set; }

        // email address, maybe this should be a list?
        public string EmailAddress { get; set; }
    }
}


