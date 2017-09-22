using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Residence
    {
        //primary key
        public int ResidenceID { get; set; }

        //foreign keys
        public int CustomerID { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EquipmentDescription { get; set; }
        public string Notes { get; set; }
    }
}

