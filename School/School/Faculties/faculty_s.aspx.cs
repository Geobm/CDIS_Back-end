using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using School_BLL;


namespace School.Faculties
{

    //Code behind Select screen.
    public partial class faculty_s : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                //Data source its a table
                grd_faculties.DataSource = LoadFaculty();
                grd_faculties.DataBind();
            }
        }

        //USING BLL as a bridge for the DAL 

        public DataTable LoadFaculty() {

            Faculty_BLL facultyBLL = new Faculty_BLL();
            DataTable dtFaculty = new DataTable();

           //Fill up the table with method LoadFaculty
            dtFaculty = facultyBLL.LoadFaculty();

            return dtFaculty;     
        
        }

        protected void grd_faculties_RowCommand(object sender, GridViewCommandEventArgs e){

            if (e.CommandName == "Edit")
            {

                Response.Redirect("/Faculties/faculties_u.aspx?pID_Faculty="+e.CommandArgument);
            }
            else {

                Response.Redirect("/Faculties/faculties_d.aspx?pID_Faculty="+e.CommandArgument);

            }   
        }
    }
}