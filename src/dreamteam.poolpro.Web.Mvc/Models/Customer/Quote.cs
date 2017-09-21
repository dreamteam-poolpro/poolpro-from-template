using dreamteam.poolpro.Web.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Quote
    {
        //primary key
        public int QuoteID { get; set; }

        //foreign key
        public int CustomerID { get; set; }

        // cutomer data would come from the CustomerID foreign key?
        // so these shouldn't be here in the Quote Model class right? 
        public Customer Customer { get; set; }
        public Residence Residence { get; set; }

        //ie. 50# bags of quartz mix, 5, $50/bag, $250
        //    labor hours, 200, 
        public List<LineItem> LineItems;

        //notes directly related to the quote
        public string Notes;

        //sum of all of the line item total, might need to be a function
        public double TotalCost;

        //the date the quote was created
        public DateTime DateCreated;

        //the date the quote was turned in to a work order
        public DateTime DateConverted;
    }
}