using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace NorthwindLibrary
{
    public class DataAccess
    {
        public List<Customer> GetCustomers(string partialCompanyName)
        {
            //throw new NotImplementedException(); //Allows compilation before code has been put in
            //Note: Needs Nuget package System.Data.SqlClient
            using //Using disposes of connection once the task has been completed
                    //"opens the door" to the database so that the next part can request data
                (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal("NorthwindDB")))


            {
                //Old direct SQL 
                //string queryString = "'%" + customerName + "%'"; //customerName was previously the passed in parameter
                //var output = connection.Query<Customer>($"SELECT * from dbo.Customers where CompanyName like {queryString};").ToList();
                
                // Now using Stored procedure
                var output = connection.Query<Customer>("dbo.GetCustomerByPartialCompanyName @PartialCompanyName", new { PartialCompanyName = partialCompanyName }).ToList();
                // new { PartialCompanyName  must match @PartialCompanyName
                // = partialCompanyName matches parameter passed into method
                // new { PartialCompanyName = partialCompanyName } is a temporary class definition without name. Class has property PartialCompanyName

                return output;
                //Returns iNumerable of type Customer, therefore .ToList needed
            }; //Connection is closed at this point because of using statement
        }
    }
}
