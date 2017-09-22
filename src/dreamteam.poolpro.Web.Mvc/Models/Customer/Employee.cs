using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Employee
    {
        // primary key
        public int EmployeeID { get; set; }

        // name
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // role
        public enum JobTitle
        {
            Admin, Manager, ServiceTech
        }

        // hire date, hourly rate, contract# etc... could be added later
        // but name is enough to get the apps main functionality up and
        // running

    }
}
