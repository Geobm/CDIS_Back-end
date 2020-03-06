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
    public partial class faculty_s : SchoolTheme, AccessI
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (InitiatedSession())
                {
                    //Data source its a table
                    grd_faculties.DataSource = LoadFaculty();
                    grd_faculties.DataBind();
                }
                else {

                    Response.Redirect("/Login.aspx");
                
                }
               
            }
        }

        //USING BLL as a bridge for the DAL 

        public List<object> LoadFaculty() {

            Faculty_BLL facultyBLL = new Faculty_BLL();
            List<object> listFaculties = new List<object>();
            listFaculties = facultyBLL.LoadFaculty();

            //return my list type object
            return listFaculties;     
        
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
        //Implemented interface to validate session
        public bool InitiatedSession(){

            if (Session["User"] != null) {
                return true;
            }
            else{
                return false;
            }
        }
    }
}