using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace School_DA
{
   public class StateDAL{

        public DataTable LoadState()
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "Load_State";
            sqlcommand.Connection = connection;

            //Adapter 
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Fill up Faculty table
            DataTable dtState = new DataTable();

            connection.Open();

            //select Sotred Procedure with adapter
            adapter.SelectCommand = sqlcommand;
            adapter.Fill(dtState);

            connection.Close();

            return dtState;

        }
    }
}
