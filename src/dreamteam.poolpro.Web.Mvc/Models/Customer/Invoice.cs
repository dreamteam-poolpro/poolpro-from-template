using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Invoice
    {
        // primary key
        public int InvoiceID { get; set; }

        // foreign keys
        public int CustomerID { get; set; }
        //public int BillingAddressID { get; set; } - not sure if this is needed here
        public int ResidenceID { get; set; }
        public int QuoteID { get; set; }
        public int WorkOrderID { get; set; }
    
        //to hold all of it's line items
        public ICollection<LineItem> LineItems { get; set; }

        //to track all the payments made on this invoice
        public ICollection<Payment> Payments { get; set; }


        // total cost
        public double TotalCost()
        {
            double totalCost = 0;
            foreach(LineItem item in LineItems)
            {
                totalCost += item.TotalCost();
            }
            return totalCost;
        }

        // total amount paid
        public double TotalPaid()
        {
            double totalPaid = 0;
            foreach (Payment pmt in Payments)
            {
                totalPaid += pmt.AmountPaid;
            }
            return totalPaid;
        }

        //the amount that is still due on the invoice
        public double AmountDue()
        {
            return TotalCost() - AmountDue();
        }     
    }
}

