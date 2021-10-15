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
        public List<Customer> GetCustomers(string CustomerName)
        {
            //throw new NotImplementedException(); //Allows compilation before code has been put in

            using //Using disposes of connection once the task has been completed
                (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal("NorthwindDB")))
            //Note: Needs Nuget package System.Data.SqlClient

            {
                var output = connection.Query<Customer>($"SELECT * from dbo.Customers where contains (CompanyName, '{CustomerName}');").ToList();
                return output;
                //Returns iNumerable of type Customer, therefore .ToList needed
            }; //Connection is closed at this point because of using statement
        }
    }
}
