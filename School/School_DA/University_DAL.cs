using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

//Data Acces Layer to load University

namespace School_DA
{
    public class University_DAL{

        public DataTable Load_University()
        {


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "select_LoadUniversity";
            sqlcommand.Connection = connection;

            //Adapter 
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable dtUniversity = new DataTable();

            connection.Open();

            //select Sotred Procedure with adapter
            adapter.SelectCommand = sqlcommand;
            adapter.Fill(dtUniversity);

            connection.Close();

            return dtUniversity;
        }

    }
}
