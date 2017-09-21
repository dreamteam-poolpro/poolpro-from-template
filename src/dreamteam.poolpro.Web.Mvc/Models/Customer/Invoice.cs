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
        public int QuoteID { get; set; }
        public int WorkOrderID { get; set; }

        // a list of line items completed from the work order
        public List<LineItem> LineItems;

        // list of payments that have been made
        public List<Payment> Payments;

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

