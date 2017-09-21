using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dreamteam.poolpro.Web.Models;
namespace dreamteam.poolpro.Web.Models.Customer
{
    public class WorkOrder
    {
        // primary key
        public int WorkOrderID { get; set; }

        // foreign keys
        
        //customer the qute is for
        public int CustomerID { get; set; }
        public int QuoteID { get; set; }
        public int EmployeeID { get; set; }
        
        // List of line items
        List<LineItem> LineItems { get; set; }

        // The date the job is scheduled to be started
        DateTime ScheduledStart { get; set; }

        // The date the job is scheduled to be completed
        DateTime ScheduledCompletion { get; set; }

        // notes carried over from quote,
        // and can be added to, should probably be a list of notes
        // so the old ones don't get deleted but that's not
        // essential to get the app up and running
        string Notes { get; set; }
    }
}