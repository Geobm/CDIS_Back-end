using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using School_BLL;
using School_DA;

namespace School.Faculties
{
    public partial class faculties_d : SchoolTheme, AccessI
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            #region events
            if (!IsPostBack){
                if (InitiatedSession())
                {
                    int ID_University = int.Parse(Request.QueryString["pID_Faculty"]);
                    Load_University();
                    LoadFaculty(ID_University); ;
                }
                else {

                    Response.Redirect("/Login.aspx");
                }
                  

            }

        }
        //Click button action
        protected void Deletebtn_Click(object sender, EventArgs e)
        {           
                Delete_Faculty();
                ClearFields();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Delete", "alert('The information was correctly deleted')", true);    
        }

        #endregion events

        #region Methods
        public void LoadFaculty(int ID_Faculty)
        {

            //Instance of BLL layer 
            Faculty_BLL faculty_BLL = new Faculty_BLL();
            Faculty faculty = new Faculty();

            
            faculty = faculty_BLL.LoadFaculty(ID_Faculty);

            //Show each field of the selected row
            lblID_Faculty.Text = faculty.ID_Faculty.ToString();
            lblCode.Text = faculty.Code;
            lblName.Text = faculty.Name;
            lblCreation_date.Text = faculty.Creation_date.ToString().Substring(0,10);
            ddlUniversity.SelectedValue = faculty.University.ToString();


        }

        //Initialize the fields to empty
        public void ClearFields()
        {
            lblID_Faculty.Text = "";
            lblCode.Text = "";
            lblName.Text = "";
            lblCreation_date.Text = "";
            ddlUniversity.SelectedIndex = 0;
      
            
        }

        public void Load_University(){
            //Instance of BLL layer 
            University_BLL university_BLL = new University_BLL();

            List<University> listUniversities = new List<University>();
            listUniversities = university_BLL.Load_University();

            ddlUniversity.DataSource = listUniversities;
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
        //Implemented interface to validate session
        public bool InitiatedSession()
        {
            if (Session["User"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Methods
    }
}