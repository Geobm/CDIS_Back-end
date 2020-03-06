using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace School
{
    public class SchoolTheme : System.Web.UI.Page{

        protected void Page_PreInit(object sender, EventArgs e) {

            if (Session["User"] != null)
            {
                DataTable dtUser = new DataTable();
                dtUser = (DataTable)Session["User"];
                string type = dtUser.Rows[0]["Type"].ToString();

                if (type == "Administrator") {
                    Page.Theme = "Theme1";
                }
                else{
                    Page.Theme = "Theme2";
                }
        }
    }
    

    }
}