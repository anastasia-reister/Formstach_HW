using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormStack_.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public  void AddForm(string Name, string Description, string Date)
        {
            //connection string for the db, acquired from object explorer
            string _connectionString = @"Data Source=ANASTASIA\SQLExpress;Initial Catalog=Form;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //query string to add data from the form to the db
            string queryString = @"Insert into Form([Name], [Description], [Date]) VALUES (@Name, @Description, @Date)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                //assigns values to the respective fields in the table
                command.Parameters.Add("@Name", SqlDbType.VarChar);
                command.Parameters.Add("@Description", SqlDbType.VarChar);
                command.Parameters.Add("@Date", SqlDbType.Date);

                command.Parameters["@Name"].Value = Name;
                command.Parameters["@Description"].Value = Description;
                command.Parameters["@Date"].Value = Convert.ToDateTime(Date);

                //establishes connection, executes query, closes connection
                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();


            }

        }
        public ActionResult Index()
        {
            return View();
        }

        
    }
}