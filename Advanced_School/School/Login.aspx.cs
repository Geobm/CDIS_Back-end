using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using School_BLL;
using System.Data;



namespace School
{
    public partial class Login : System.Web.UI.Page
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e){

        }

        protected void btnlogin_Click(object sender, EventArgs e) {
            if (Valid_User()) {
                Response.Redirect("~/Faculties/faculty_s.aspx");
            }
            else {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Session", "alert('Incorrect User name or password')",true);
            
            }
        }
        #endregion Events

        #region Methods

        public bool Valid_User() {
            //Validate User 
            bool access = false;
            UserBLL userBLL = new UserBLL();
            DataTable dtUser = new DataTable();

            dtUser = userBLL.CheckUser(txtUserName.Text, txtPassword.Text);

            if (dtUser.Rows.Count > 0) {

                Session["User"] = dtUser;
                access = true;

            }
            return access;
        }
        
        
        #endregion Methods
    }
}