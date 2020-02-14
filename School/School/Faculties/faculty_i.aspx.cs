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
    //Code behind Insert screen.

    public partial class faculty_i : System.Web.UI.Page
    {
        #region Events

        protected void Page_Load(object sender, EventArgs e){
            if (!IsPostBack){
                
                Load_University();
            }
        }

        protected void Addbtn_Click(object sender, EventArgs e){

                AddFaculty();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Registration", "alert('The faculty was correctly added')", true);
      
        }

        #endregion Events
        #region Methods

        public void AddFaculty(){

            Faculty_BLL facultyBLL = new Faculty_BLL();

            string Code = txtCode.Text;
            string Name = txtName.Text;
            DateTime Creation_Date = Convert.ToDateTime(txtCreationDate.Text);
            int University = int.Parse(ddlUniversity.SelectedValue);

            facultyBLL.AddFaculty(Code,Name,Creation_Date,University);

        }

        #endregion Methods

        protected void Load_University(){

            University_BLL universityBLL = new University_BLL();
            DataTable dtUniversity = new DataTable();

            dtUniversity = universityBLL.Load_University();

            ddlUniversity.DataSource = dtUniversity;
            ddlUniversity.DataTextField = "Name";
            ddlUniversity.DataTextField = "ID_University";
            ddlUniversity.DataBind();

            ddlUniversity.Items.Insert(0, new ListItem("-----Select the University-----", "0"));

        }
    }
}