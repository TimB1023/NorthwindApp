using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NorthwindLibrary
{
    public class Customer
    {
        public string CustomerID { get; set; } // Note this is called an auto-implemented property as it does not refer to a private field (at least not visibly)
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string customerDisplayName 
        {
            get
            { return $"{CompanyName} ({CustomerID})"; }
        }
        public string AddressBlock
        {
            get
            {
                string BlockText = $"{Address}\n{City}\n{Region}\n{PostalCode}\n{Country}"; // Combines address elements into a block
                return Regex.Replace(BlockText, "\n\n", "\n"); // Removes double new line, i.e. where there is an empty line such as with Region
            }
        }
        public decimal OrdersToDate { get; set; }

        public decimal SumOfOrders => NorthwindMethods.SumOfOrdersByCustomerID(CustomerID);

        public DateTime EarliestOrderDate
        {
            get { return NorthwindMethods.EarliestOrderDateByCustomerID(CustomerID); }
            //See more efficient code under latest date, below
        }

        public DateTime LatestOrderDate => NorthwindMethods.LatestOrderDateByCustomerID(CustomerID);

        //public decimal SumOfOrders

        public decimal MaxOrdersByAnyCustomer => NorthwindMethods.MaxRevenueByAnyCustomer(); // Needed here to be able to include in the datagrid
        
    }
}
