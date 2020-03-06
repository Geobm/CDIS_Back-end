using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace School_DA
{
    public class CityDAL
    {
        public DataTable Load_CityState(int State)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "Load_CityState";
            sqlcommand.Connection = connection;

            sqlcommand.Parameters.AddWithValue("pState",State);

            //Adapter 
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Fill up Faculty table
            DataTable dtCity = new DataTable();

            connection.Open();

            //select Sotred Procedure with adapter
            adapter.SelectCommand = sqlcommand;
            adapter.Fill(dtCity);

            connection.Close();

            return dtCity;

        }

    }
}
