using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class BillingAddress
    {
        //number, street, and unit
        //ie. 1234 main street unit A
        public string StreetAddress { get; set; }

        //city
        public string City { get; set; }

        //state
        public string State { get; set; }

        //zipcode
        public string ZipCode { get; set; }

        //any notes, such as a 'Attn: Accounts Payable'
        public string Notes { get; set; }
    }
}
