using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_DA;


namespace School_BLL
{
    public class SubjectFaculty_BLL{

        public void addFacultySubject(SubjectFaculty subject) {

            SubjectFaculty_DAL subjFaculty = new SubjectFaculty_DAL();
            subjFaculty.addFacultySubject(subject);
        }
    }
}
