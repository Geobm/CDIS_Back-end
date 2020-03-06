using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace School_DA
{
    public class Faculty_DAL {

        //Class working over entities model

        SchoolEntities model;

        public Faculty_DAL() {

            model = new SchoolEntities();
        }


        public List<object> LoadFaculty(){

            var faculties = from mFaculty in model.Faculty
                            
                            select new {
                                ID_Faculty = mFaculty.ID_Faculty,
                                name = mFaculty.Name,
                                code = mFaculty.Code,
                                creation_Date = mFaculty.Creation_date,
                                universityName = mFaculty.University1.Name,
                                cityName = mFaculty.City1.Name,
                                
                            };
            //return the values as a enumerable collection and then as a list.
            return faculties.AsEnumerable<object>().ToList();
        }

        public void AddFaculty(Faculty faculty){

            model.Faculty.Add(faculty);
            model.SaveChanges();

        }

   

        public Faculty LoadFaculty(int ID_Faculty){

            var faculty= (from mFaculty in model.Faculty
                             where mFaculty.ID_Faculty == ID_Faculty
                             select mFaculty).FirstOrDefault();
            return faculty;
        }

        public void UpdateFaculty(Faculty pfaculty){

            var faculty = (from mFaculty in model.Faculty
                           where mFaculty.ID_Faculty == pfaculty.ID_Faculty
                           select mFaculty).FirstOrDefault();
            
            faculty.Code = pfaculty.Code;
            faculty.Name = pfaculty.Name;
            faculty.Creation_date = pfaculty.Creation_date;
            faculty.University = pfaculty.University;
            faculty.City = pfaculty.City;

            model.SaveChanges();

        }

        public void Delete_Faculty(int ID_Faculty){
            
            var faculty = (from mFaculty in model.Faculty
                           where mFaculty.ID_Faculty == ID_Faculty
                           select mFaculty).FirstOrDefault();

            model.Faculty.Remove(faculty);
            model.SaveChanges();
 
        }
    }
}
