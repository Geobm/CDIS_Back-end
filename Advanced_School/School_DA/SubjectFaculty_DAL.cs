using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_DA
{
   public class SubjectFaculty_DAL{
        
        SchoolEntities model;

        public SubjectFaculty_DAL() {

            //use model as reference
            model = new SchoolEntities();
        }

        public void addFacultySubject(SubjectFaculty subject) {

            model.SubjectFaculty.Add(subject);
            model.SaveChanges();
        
        }
    }
}
