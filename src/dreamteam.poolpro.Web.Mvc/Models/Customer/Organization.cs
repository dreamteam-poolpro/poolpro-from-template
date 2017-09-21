using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Organization
    {
        // legal name of the organization
        public string Name { get; set; }

        // tax id for 1099 or any other tax related documentation
        public string TaxId { get; set; }
    }
}

