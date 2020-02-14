using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using School_BLL;


namespace School.Faculties
{
    public partial class faculties_u : System.Web.UI.Page
    {

        #region events 
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //Select all the fields from database where ID_University
                int ID_University = int.Parse(Request.QueryString["pID_Faculty"]);
                Load_University();
                LoadFaculty(ID_University);
                

            }

        }
        //Click button action
        protected void Edittbn_Click(object sender, EventArgs e){
            try
            {
                UpdateFaculty();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Registration", "alert('The information was correctly modified')", true);
            }
            catch (Exception)
            {
                
            }
               
           
        }

        #endregion events

        #region Methods
        public void LoadFaculty(int ID_Faculty) {
            
            //Instance of BLL layer 
            Faculty_BLL faculty_BLL = new Faculty_BLL();

            DataTable dtFaculty = new DataTable();
            dtFaculty = faculty_BLL.LoadFaculty(ID_Faculty);

            //Show each field of the selected row
            lblID_Faculty.Text = dtFaculty.Rows[0]["ID_Faculty"].ToString();
            txtCode.Text = dtFaculty.Rows[0]["Code"].ToString();
            txtName.Text = dtFaculty.Rows[0]["Name"].ToString();
            txtCreationDate.Text = dtFaculty.Rows[0]["Creation_date"].ToString();
            ddlUniversity.SelectedValue = dtFaculty.Rows[0]["University"].ToString();

        }

        protected void Load_University(){
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

        public void UpdateFaculty() {

            Faculty_BLL facultyBLL = new Faculty_BLL();


            int ID_Faculty = int.Parse(lblID_Faculty.Text);
            string Code = txtCode.Text;
            string Name = txtName.Text;
            DateTime Creation_Date = Convert.ToDateTime(txtCreationDate);
            int University = int.Parse(ddlUniversity.SelectedValue);
            
            //Modify values of each control 
            facultyBLL.UpdateFaculty(ID_Faculty,Code,Name,Creation_Date,University);
            
        }

        #endregion Methods

    }
}