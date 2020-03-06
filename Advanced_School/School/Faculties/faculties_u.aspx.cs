using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using School_BLL;
using School_DA;


namespace School.Faculties
{
    public partial class faculties_u : SchoolTheme, AccessI
    {

        #region events 
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (InitiatedSession())
                {
                    //Select all the fields from database where ID_University
                    int ID_University = int.Parse(Request.QueryString["pID_Faculty"]);
                    Load_University();
                    LoadFaculty(ID_University);
                }
                else{

                    Response.Redirect("/Login.aspx");
                
                }

            }

        }
        //Click button action
        protected void Edittbn_Click(object sender, EventArgs e){
          
                UpdateFaculty();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Registration", "alert('The information was correctly modified')", true);
            
       
        }
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlState.SelectedIndex != 0)
            {

                ddlCity.Items.Clear();
                LoadCity();
            }
            else
            {

                ddlCity.Items.Clear();

            }
        }

        #endregion events

        #region Methods
        public void LoadFaculty(int ID_Faculty) {
            
            //Instance of BLL layer 
            Faculty_BLL faculty_BLL = new Faculty_BLL();

            Faculty faculty = new Faculty();
            faculty = faculty_BLL.LoadFaculty(ID_Faculty);

            //Show each field of the selected row
            lblID_Faculty.Text = faculty.ID_Faculty.ToString();
            txtCode.Text = faculty.Code.ToString();
            txtName.Text = faculty.Name.ToString();
            txtCreationDate.Text = faculty.Creation_date.ToString().Substring(0,10);
            ddlUniversity.SelectedValue = faculty.University.ToString();

            LoadState();
            ddlState.SelectedValue = faculty.City1.State.ToString();

            LoadCity();
            ddlCity.SelectedValue = faculty.City.ToString();

        }

        protected void Load_University(){
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


        public void LoadCity()
        {

            CityBLL city = new CityBLL();
            DataTable dtCity = new DataTable();

            dtCity = city.Load_CityState(int.Parse(ddlState.SelectedValue));

            ddlCity.DataSource = dtCity;
            ddlCity.DataTextField = "Name";
            ddlCity.DataValueField = "ID_City";
            ddlCity.DataBind();

            ddlCity.Items.Insert(0, new ListItem("-----Select City-----", "0"));

        }

        public void LoadState()
        {
            StateBLL state = new StateBLL();
            DataTable dtstates = new DataTable();

            dtstates = state.LoadState();

            ddlState.DataSource = dtstates;
            ddlState.DataTextField = "Name";
            ddlState.DataValueField = "ID_State";
            ddlState.DataBind();

            ddlState.Items.Insert(0, new ListItem("-----Select State-----", "0"));

        }

        public void UpdateFaculty() {

            Faculty_BLL facultyBLL = new Faculty_BLL();

            Faculty faculty = new Faculty();

            faculty.ID_Faculty = int.Parse(lblID_Faculty.Text);
            faculty.Code = txtCode.Text;
            faculty.Name = txtName.Text;
            faculty.Creation_date = Convert.ToDateTime(txtCreationDate.Text);
            faculty.University = int.Parse(ddlUniversity.SelectedValue);
            faculty.City = int.Parse(ddlCity.SelectedValue);

            //Modify values of each control 
            facultyBLL.UpdateFaculty(faculty);
            
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