using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using School_DA;

//Business Logic Layer

namespace School_BLL
{
   public class Faculty_BLL{

        //Instance of each method

        public DataTable LoadFaculty(){

            Faculty_DAL faculty = new Faculty_DAL();
            return faculty.LoadFaculty();
        }

        public void AddFaculty(string Code, string Name, DateTime Creation_Date, int University){

            Faculty_DAL faculty = new Faculty_DAL();
            faculty.AddFaculty(Code, Name, Creation_Date, University);
        }

        public DataTable LoadFaculty(int ID_Faculty){

                Faculty_DAL faculty = new Faculty_DAL();
                return faculty.LoadFaculty(ID_Faculty);
            }

        public void UpdateFaculty(int ID_Faculty, string Code, string Name, DateTime Creation_Date, int University){

            Faculty_DAL faculty = new Faculty_DAL();
            faculty.UpdateFaculty(ID_Faculty, Code, Name, Creation_Date, University);

        }

        public void Delete_Faculty(int ID_Faculty) {

            Faculty_DAL faculty = new Faculty_DAL();
            faculty.Delete_Faculty(ID_Faculty);
            
        }

    }
}
