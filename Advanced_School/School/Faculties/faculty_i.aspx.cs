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
    //Code behind Insert screen.

    public partial class faculty_i : SchoolTheme, AccessI
    {
        #region Events

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                if (InitiatedSession())
                {
                    Load_University();
                    LoadState();
                    LoadTable();
                    LoadSubjects();
                }
                else {

                    Response.Redirect("/Login.aspx");
                }
            }
        }

        protected void Addbtn_Click(object sender, EventArgs e) {


            try
            {
                AddFaculty();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Registration", "alert('The faculty was correctly added')", true);

                ClearFields();
            }
            catch (Exception)
            {

                throw new Exception("A problem ocurred");
            }

        }
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e) {

            if (ddlState.SelectedIndex != 0) {

                ddlCity.Items.Clear();
                LoadCity();
            }
            else {

                ddlCity.Items.Clear();

            }
        }

        #endregion Events

        #region Methods

        public void AddFaculty() {

            Faculty_BLL facultyBLL = new Faculty_BLL();
            Faculty faculty = new Faculty();

            //Accesing to the attributes from my faculty object
            faculty.Code = txtCode.Text;
            faculty.Name = txtName.Text;
            faculty.Creation_date = Convert.ToDateTime(txtCreationDate.Text);
            faculty.University = int.Parse(ddlUniversity.SelectedValue);
            faculty.City = int.Parse(ddlCity.SelectedValue);

            try
            {
                //LINQ 
                SubjectFaculty subjectFaculty;
                List<SubjectFaculty> subjectList = new List<SubjectFaculty>();

                foreach (ListItem item in SubjectListBox.Items) {

                    if (item.Selected) {

                        subjectFaculty = new SubjectFaculty();
                        subjectFaculty.subject = int.Parse(item.Value);
                        subjectFaculty.faculty = faculty.ID_Faculty;
                        subjectList.Add(subjectFaculty);                                    
                    }
                
                }

                facultyBLL.AddFaculty(faculty//,subjectList
                    );
                ClearFields();

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Registration", "alert('" + ex.Message + "')", true);

            }

        }


        public void Load_University()
        {
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

        public void LoadTable() {

            DataTable dt = new DataTable();

            dt.Columns.Add("Code");
            dt.Columns.Add("Name");

            ViewState["FacultyTable"] = dt;


        }

        public void LoadSubjects(){

            Subject_BLL subject = new Subject_BLL();
            List<Subject> Subjectlist = new List<Subject>();

            Subjectlist = subject.LoadSubjects();

            SubjectListBox.DataSource = Subjectlist;
            SubjectListBox.DataTextField = "SubjectName";
            SubjectListBox.DataValueField = "ID_Subject";
            SubjectListBox.DataBind();

        }

        //Initialize the fields to empty
        public void ClearFields() {
            txtCode.Text = "";
            txtName.Text = "";
            txtCreationDate.Text = "";
            ddlUniversity.SelectedIndex = 0;
            ddlCity.SelectedIndex = 0;
            ddlState.SelectedIndex = 0;
        }

        public void LoadCity() {

            CityBLL city = new CityBLL();
            DataTable dtCity = new DataTable();

            dtCity = city.Load_CityState(int.Parse(ddlState.SelectedValue));

            ddlCity.DataSource = dtCity;
            ddlCity.DataTextField = "Name";
            ddlCity.DataValueField = "ID_City";
            ddlCity.DataBind();

            ddlCity.Items.Insert(0, new ListItem("-----Select City-----","0"));
        
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