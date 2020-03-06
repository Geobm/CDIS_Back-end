using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using School_DA;
using System.Transactions;
using School_BLL;

//Business Logic Layer

namespace School_BLL
{
    public class Faculty_BLL {

        //Instance of each method
        public List<object> LoadFaculty() {

            Faculty_DAL faculty = new Faculty_DAL();
            return faculty.LoadFaculty();
        }

        public void AddFaculty(Faculty paramFaculty)
        {

            Faculty_DAL facultyDAL = new Faculty_DAL();
            Faculty Faculty = new Faculty();
            SubjectFaculty_BLL subjectFacultyBLL = new SubjectFaculty_BLL();

            Faculty = LoadFaculty(paramFaculty.ID_Faculty);
            
                    //Use of transactions
              //      using ( TransactionScope ts = new TransactionScope()) {

                    facultyDAL.AddFaculty(paramFaculty);

                       //  foreach (SubjectFaculty subject in subjectList) {

                            //Multiple inserts 
                         //   subjectFacultyBLL.addFacultySubject(subject);

                //         }

                    //    ts.Complete();
                  //  }
        }

        public Faculty LoadFaculty(int ID_Faculty){

                Faculty_DAL faculty = new Faculty_DAL();
                return faculty.LoadFaculty(ID_Faculty);
            }

        public void UpdateFaculty(Faculty paramFaculty){

            Faculty_DAL faculty = new Faculty_DAL();
            faculty.UpdateFaculty(paramFaculty);

        }

        public void Delete_Faculty(int ID_Faculty) {

            Faculty_DAL faculty = new Faculty_DAL();
            faculty.Delete_Faculty(ID_Faculty);
            
        }

    }
}
