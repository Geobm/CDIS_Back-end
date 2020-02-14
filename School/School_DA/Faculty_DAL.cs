using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace School_DA
{
    public class Faculty_DAL{
        
        public DataTable LoadFaculty()
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "select_LoadFaculty";
            sqlcommand.Connection = connection;

            //Adapter 
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Fill up Faculty table
            DataTable dtFaculty = new DataTable();

            connection.Open();

            //select Sotred Procedure with adapter
            adapter.SelectCommand = sqlcommand;
            adapter.Fill(dtFaculty);

            connection.Close();

            return dtFaculty;

        }

        public void AddFaculty(string Code, string Name, DateTime Creation_Date,int  University)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Insert Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "insert_AddFaculty";
            sqlcommand.Connection = connection;

            
            sqlcommand.Parameters.AddWithValue("pCode", Code);
            sqlcommand.Parameters.AddWithValue("pName", Name);
            sqlcommand.Parameters.AddWithValue("pCreation_Date", Creation_Date);
            sqlcommand.Parameters.AddWithValue("pUniversity", University);
            connection.Open();

            //Execute command on Database
            sqlcommand.ExecuteNonQuery();

            connection.Close();

        }


        public DataTable LoadFaculty(int ID_Faculty)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "select_LoadIDFaculty";
            sqlcommand.Connection = connection;

            sqlcommand.Parameters.AddWithValue("pID_Faculty", ID_Faculty);

            //Adapter 
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Fill up Faculty table
            DataTable dtFaculty = new DataTable();

            connection.Open();

            //select Sotred Procedure with adapter
            adapter.SelectCommand = sqlcommand;
            adapter.Fill(dtFaculty);

            connection.Close();

            return dtFaculty;
        }

        public void UpdateFaculty(int ID_Faculty, string Code, string Name, DateTime Creation_Date, int University)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();

            //Update Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "update_Faculty";
            sqlcommand.Connection = connection;

            //Parameters to be modified 
            sqlcommand.Parameters.AddWithValue("pID_Faculty", ID_Faculty);
            sqlcommand.Parameters.AddWithValue("pCode", Code);
            sqlcommand.Parameters.AddWithValue("pName", Name);
            sqlcommand.Parameters.AddWithValue("pCreation_Date",Creation_Date);
            sqlcommand.Parameters.AddWithValue("pUniversity", University);
            connection.Open();

            //Execute command on Database
            sqlcommand.ExecuteNonQuery();

            connection.Close();

        }

        public void Delete_Faculty(int ID_Faculty)
        {


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=FS01-605484-PC\ROOT1;Database=School;Trusted_connection=true";

            SqlCommand sqlcommand = new SqlCommand();
            //Insert Sotred Procedure
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = "Delete_Faculty";
            sqlcommand.Connection = connection;

            //Parameters to be added 
            sqlcommand.Parameters.AddWithValue("pID_Faculty", ID_Faculty);
            connection.Open();

            //Execute command on Database
            sqlcommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}
