using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace School_DA
{
    public class User_DAL{

        public DataTable CheckUser(string Name, string Password) {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "CheckUser";
            sqlcommand.Connection = connection;


            sqlcommand.Parameters.AddWithValue("@pName", Name);
            sqlcommand.Parameters.AddWithValue("@pPassword", Password);
            
            //Adapter 
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Fill up Faculty table
            DataTable dtUser = new DataTable();

            connection.Open();

            //select Sotred Procedure with adapter
            adapter.SelectCommand = sqlcommand;
            adapter.Fill(dtUser);

            connection.Close();

            return dtUser;

        }
    }
}
