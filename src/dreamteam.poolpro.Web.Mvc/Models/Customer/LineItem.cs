using System;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class LineItem
    {
        //primary key
        public int LineItemID { get; set; }

        //foreign key
        public int InvoiceID { get; set; }

        // line itsm should looks like this:
        // Quantity Units   of  Description at UnitCost per   Unit  equals TotalCost()
        //    10    hours   of  labor       at $50      per   hour  equals $500
        //    50    bags    of  QuartsCoat  at $150     per   bag   equals $7500

        //description
        public string Description { get; set; }

        //unit
        public string Unit { get; set; }

        //unit cost
        public double UnitCost { get; set; }

        //quaitity
        public double Quantity { get; set; }

        //when the line item was created
        public DateTime CreationTime { get; set; }

        //total cost
        public double TotalCost()
        {
            return Quantity * UnitCost;
        }

        //Scheduled is for if the line item has been scheduled but is not being worked on
        //InProgress is for when the line item is being worked on
        //Completed is for when the line item has been completed
        //Invoiced is for when the LineItem has been converted to an Invoice
        public enum Status
        {
            Scheduled, InProgress, Completed, Invoiced
        }        
    }
}