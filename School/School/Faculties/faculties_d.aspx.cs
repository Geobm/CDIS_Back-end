using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using School_BLL;

namespace School.Faculties
{
    public partial class faculties_d : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            #region events
            if (!IsPostBack){

              int ID_University = int.Parse(Request.QueryString["pID_Faculty"]);
              Load_University();
              LoadFaculty(ID_University); ;

            }

        }
        //Click button action
        protected void Deletebtn_Click(object sender, EventArgs e)
        {           
                Delete_Faculty();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Delete", "alert('The information was correctly deleted')", true);    
        }

        #endregion events

        #region Methods
        public void LoadFaculty(int ID_Faculty)
        {

            //Instance of BLL layer 
            Faculty_BLL faculty_BLL = new Faculty_BLL();

            DataTable dtFaculty = new DataTable();
            dtFaculty = faculty_BLL.LoadFaculty(ID_Faculty);

            //Show each field of the selected row
            lblID_Faculty.Text = dtFaculty.Rows[0]["ID_Faculty"].ToString();
            lblCode.Text = dtFaculty.Rows[0]["Code"].ToString();
            lblName.Text = dtFaculty.Rows[0]["Name"].ToString();
            lblCreation_date.Text = dtFaculty.Rows[0]["Creation_date"].ToString();
            ddlUniversity.SelectedValue = dtFaculty.Rows[0]["University"].ToString();

        }


        public void Load_University(){
            //Instance of BLL layer 
            University_BLL university_BLL = new University_BLL();

            DataTable dtUniversity = new DataTable();
            dtUniversity = university_BLL.Load_University();

            ddlUniversity.DataSource = dtUniversity;
            ddlUniversity.DataTextField = "Name";
            ddlUniversity.DataValueField = "ID_University";
            ddlUniversity.DataBind();

            ddlUniversity.Items.Insert(0, new ListItem("-----Select the University-----", "0"));
        }

        public void Delete_Faculty() {

            Faculty_BLL facultyBLL = new Faculty_BLL();

            int ID_Faculty = int.Parse(lblID_Faculty.Text);

            facultyBLL.Delete_Faculty(ID_Faculty);

        }  
        
        #endregion Methods
    }
}