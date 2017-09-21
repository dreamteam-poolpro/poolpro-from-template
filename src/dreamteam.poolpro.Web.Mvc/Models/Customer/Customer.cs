using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Customer
    {
        // primary key for Customer, but it gets attached to the 
        // associated quotes, work orders, invoices and payments as a foreign key
        public int CustomerID { get; set; }

        // in the case of a customer being a business instead of a person
        public Organization Organization { get; set; }

        // if it's a busines then this will be the primary contact at the business, 
        // otherwise it will be the actual customer
        public Person Person { get; set; }

        // address where bills or other paperwork will be mailed 
        public BillingAddress BillingAddress { get; set; }

        
    }
}


