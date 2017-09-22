using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Organization
    {
        //primary key
        public int OrganizationID { get; set; }

        //foreign key
        public int CustomerID { get; set; }

        // legal name of the organization
        public string Name { get; set; }

        // tax id for 1099 or any other tax related documentation
        public string TaxId { get; set; }
    }
}

